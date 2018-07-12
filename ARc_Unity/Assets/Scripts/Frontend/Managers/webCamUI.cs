using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;

public class webCamUI : MonoBehaviour
{

    private ScanManager scanManager;
    public RawImage rawimage;
    public Image clickedImage;
    private const string qrImageName = "qrImageName.jpg";
    private byte[] fileData;

    private WebCamTexture webcamTexture;

    private WebCamDevice[] devices;
    private string deviceName;
    private int selectedcam;

    public float camRotationAngle;

    private bool isinitialRotationSet;

    //public GameObject backButton;
    public GameObject webCamScreen;
    private bool scanningQRCode;

    void Start()
    {
        StartCamera();
    }

    public void StartCamera()
    {

        webCamScreen.SetActive(true);

        SetwebCam(true);
        devices = WebCamTexture.devices;
        for (var i = 0; i < devices.Length; i++)
        {
            if (devices[i].isFrontFacing)
            {
                selectedcam = i;
            }
        }
        PlayCamera();
    }

    void PlayCamera()
    {

        SetwebCam(true);

        deviceName = devices[selectedcam].name;
        webcamTexture = new WebCamTexture(deviceName);
        rawimage.texture = webcamTexture;
        rawimage.material.mainTexture = webcamTexture;

        webcamTexture.Play();

    }


    public void SetwebCam(bool value)
    {

        rawimage.gameObject.SetActive(value);

    }

    void StopCamera()
    {

        webcamTexture.Stop();
    }

    public void SnapImage()
    {
        StartCoroutine("SnapImageCoroutine");
    }

    IEnumerator SnapImageCoroutine()
    {

        yield return new WaitForEndOfFrame();
        if (webcamTexture != null)
        {

            if (Application.platform == RuntimePlatform.Android)
            {
                if (selectedcam == 0)
                {
                    clickedImage.transform.localScale = new Vector3(-1, -1, 1);
                    camRotationAngle = 0;
                    clickedImage.GetComponent<RectTransform>().rotation = Quaternion.Euler(0, 0, camRotationAngle);
                }
                else
                {
                    clickedImage.transform.localScale = new Vector3(-1, 1, 1);
                    camRotationAngle = 0;
                    clickedImage.GetComponent<RectTransform>().rotation = Quaternion.Euler(0, 0, camRotationAngle);
                }
            }
            else if (Application.platform == RuntimePlatform.IPhonePlayer)
            {
                
                if (selectedcam == 0)
                {
                    clickedImage.transform.localScale = new Vector3(-1, -1, 1);
                    camRotationAngle = 0;
                    clickedImage.GetComponent<RectTransform>().rotation = Quaternion.Euler(0, 0, camRotationAngle);
                }
                else
                {
                    clickedImage.transform.localScale = new Vector3(-1, 1, 1);
                    camRotationAngle = 0;
                    clickedImage.GetComponent<RectTransform>().rotation = Quaternion.Euler(0, 0, camRotationAngle);
                }

            }

            Texture2D snap = new Texture2D(webcamTexture.width, webcamTexture.height, TextureFormat.RGB24, false);

            snap.SetPixels(webcamTexture.GetPixels(0, 0, webcamTexture.width, webcamTexture.height));
            snap.Apply();

            StopCamera();

            UploadImage(snap);

        }
        else
        {
            Debug.LogWarning("Webcam texture is null");
        }
    }

    public void UploadImage(Texture2D t)
    {

        Texture2D myTexture2D = t;

        var cropSize = 0;
        if (myTexture2D.width > myTexture2D.height)
        {
            cropSize = myTexture2D.height;
        }
        else
        {
            cropSize = myTexture2D.width;
        }

        Color[] pixels = myTexture2D.GetPixels((myTexture2D.width - cropSize) / 2, (myTexture2D.height - cropSize) / 2, cropSize, cropSize, 0);

        Texture2D img = new Texture2D(cropSize, cropSize, TextureFormat.RGB24, false);

        img.SetPixels(0, 0, cropSize, cropSize, pixels, 0);
        img.Apply();

        clickedImage.sprite = GetSprite(img);

        CloseSelfieScreen();


         //* You can save this image in local folder.
        //byte[] outBytes;
        //outBytes = img.EncodeToPNG ();
        //string outFile = Application.dataPath + "/UI_Sprites/" + "Camera" + "/" + "NewScreen.png";
        //System.IO.File.WriteAllBytes (outFile, outBytes);


    }

    public void CloseSelfieScreen(){

        StopCamera();

        SetwebCam(true);

        webCamScreen.SetActive(false);
    }

    public Sprite GetSprite (Texture2D texture){

        Texture2D old = texture;
        Texture2D left = new Texture2D((int)(old.width), old.height, old.format, false);
        Color[] colors = old.GetPixels(0, 0, (int)(old.width), old.height);
        left.SetPixels(colors);
        left.Apply();
        Sprite sprite = Sprite.Create(left, new Rect(0, 0, left.width, left.height), new Vector2(0.5f, 0.5f), 100);

        return sprite;
    }

    public void lookUp(){
      
        //start photo request
        AndroidJavaClass mediaStoreClass = new AndroidJavaClass("android.provider.MediaStore");
        AndroidJavaObject intentObject = new AndroidJavaObject("android.content.Intent");
        intentObject.Call<AndroidJavaObject>("setAction", mediaStoreClass.GetStatic<string>("ACTION_IMAGE_CAPTURE"));

        //define the path and filename to save photo taken by Camera activity
        string filePath = Application.persistentDataPath + Path.DirectorySeparatorChar + qrImageName;
        AndroidJavaClass uriClass = new AndroidJavaClass("android.net.Uri");
        AndroidJavaObject fileObject = new AndroidJavaObject("java.io.File", filePath);
        AndroidJavaObject uriObject = uriClass.CallStatic<AndroidJavaObject>("fromFile", fileObject);

        intentObject.Call<AndroidJavaObject>("putExtra", mediaStoreClass.GetStatic<string>("EXTRA_OUTPUT"), uriObject);

        // Start the activity
        AndroidJavaClass unity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject>("currentActivity");
        currentActivity.Call("startActivity", intentObject);

        scanningQRCode = true;

    }

    public void endLookup(){
        //end photo request
        string qrCodeImagePath = Application.persistentDataPath + Path.DirectorySeparatorChar + qrImageName;
        if (File.Exists(qrCodeImagePath))
        {
            // Load the image into a Texture2D
            fileData = File.ReadAllBytes(qrCodeImagePath);
            Texture2D texture2D = new Texture2D(2, 2);
            texture2D.LoadImage(fileData);

            scanManager.getProfile(texture2D);
            //string scannedText = result == null ? "" : result.Text;
            //OnQRCodeScanned(scannedText);

            File.Delete(qrCodeImagePath);
        }
        scanningQRCode = false;
 
    }
}


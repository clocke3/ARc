using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CropImage : MonoBehaviour
{


    public Texture2D t;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            Crop();
        }

    }


    void Crop()
    {

        Texture2D myTexture2D = GetReadableTexture.GetTexture(t);

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

       /// byte[] outBytes;
       // outBytes = img.EncodeToPNG();
        //string outFile = Application.dataPath + "/TableTennis/" + "Texture" + "/" + "NewScreen.png";
        //System.IO.File.WriteAllBytes(outFile, outBytes);


    }
}

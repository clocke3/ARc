using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiWebcamManager : MonoBehaviour {
    private WebCamTexture camTexture;
    private Texture defaultBackground;

    public RawImage background;
 
    private void Start(){
        defaultBackground = background.texture;
        WebCamDevice[] devices = WebCamTexture.devices;

        if (devices.Length == 0){
            Debug.Log("No camera found.");
            return;
        }

        for (int i = 0; i < devices.Length; i++){
            if (!devices[i].isFrontFacing){
                camTexture = new WebCamTexture(devices[i].name, Screen.width, Screen.height);
            }
        }

        if (camTexture == null){
            Debug.Log("Unable to find camera");
            return;
        }

        camTexture.Play();
        background.texture = camTexture;
    }

    private void Update(){
        float scaleY = camTexture.videoVerticallyMirrored ? -1f : 1f;
        background.rectTransform.localScale = new Vector3(1f, scaleY, 1f);

        int orient = camTexture.videoRotationAngle;
        background.rectTransform.localEulerAngles = new Vector3(0, 0, orient);
    }
    	
}

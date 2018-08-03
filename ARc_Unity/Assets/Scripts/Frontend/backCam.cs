using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class backCam : MonoBehaviour
{
    private WebCamTexture camTexture;
    private Texture default_background;

    public RawImage background;

    void Start()
    {
        default_background = background.texture;
        WebCamDevice[] devices = WebCamTexture.devices;

        if(devices.Length == 0){
            Debug.Log("no camera found");
            return;
        }

        for (int i = 0; i < devices.Length; i++){
            if (devices[i].isFrontFacing) {
                camTexture = new WebCamTexture(devices[i].name, Screen.width, Screen.height);
            }
        }

        if(camTexture == null){
            Debug.Log("Unable to find camera");
            return;
        }

        camTexture.Play();
        background.texture = camTexture;
    }

}
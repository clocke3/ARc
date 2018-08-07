using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WebcamThing : MonoBehaviour {

    public RawImage rawImage;
    WebCamTexture webcamTexture;

    void Start()
    {
        webcamTexture = new WebCamTexture();
        rawImage.texture = webcamTexture;
        rawImage.material.mainTexture = webcamTexture;
        webcamTexture.Play();

    }

    private void OnDestroy()
    {
        webcamTexture.Stop();
    }
}

using System.Collections.Generic;
using UnityEngine;

public class MultiWebcamManager : MonoBehaviour {

    public GameObject multiwebCamTexturePrefab;

    private string[] nameofCams;
    private List<WebCamTexture> webCamTextures = new List<WebCamTexture>();

    // Use this for initialization
    void Start()
    {
        int numOfCams = WebCamTexture.devices.Length;
        nameofCams = new string[numOfCams];

        for (int i = 0; i < numOfCams; i++)
        {

            nameofCams[i] = WebCamTexture.devices[i].name;
            GameObject go = Instantiate(multiwebCamTexturePrefab, new Vector3(i * 5, 0, 0), Quaternion.identity) as GameObject;

            go.transform.parent = gameObject.transform;

            WebCamTexture webCamTexture = new WebCamTexture();
            webCamTexture.deviceName = nameofCams[i];
            webCamTextures.Add(webCamTexture);

            go.transform.GetChild(0).GetComponent<Renderer>().material.mainTexture = webCamTextures[i];
            webCamTextures[i].Play();

        }
    }	
}

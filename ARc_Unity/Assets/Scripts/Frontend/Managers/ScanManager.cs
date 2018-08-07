using BarcodeScanner.Parser;
using BarcodeScanner.Webcam;
using System;
using UnityEngine;
using UnityEngine.UI;
using Wizcorp.Utils.Logger;

#if !UNITY_WEBGL
using System.Threading;
#endif

namespace BarcodeScanner.Scanner
{
    /// <summary>
    /// This Scanner Is used to manage the Camera and the parser and provide:
    /// * Simple methods : Scan / Stop
    /// * Simple events : OnStatus / StatusChanged
    /// </summary>
    public class ScanManager : ItemManager{
        
        public ContinuousDemo scanCam;
        public RawImage rawImage;

        public void displayProfile(string qrID) {
            currentCode = qrID;
            displayCodeProfile();
        }

        private void OnDisable()
        {
            scanCam.gameObject.SetActive(false);
            rawImage.gameObject.SetActive(true);
        }

        private void OnEnable()
        {
            rawImage.gameObject.SetActive(false);
            scanCam.gameObject.SetActive(true);
        }

    }
}

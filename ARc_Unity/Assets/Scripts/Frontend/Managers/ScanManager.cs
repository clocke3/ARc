using BarcodeScanner.Parser;
using BarcodeScanner.Webcam;
using System;
using UnityEngine;
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

        public void displayProfile(string qrID) {
            currentCode = qrID;
            displayCodeProfile();
        }

    }
}

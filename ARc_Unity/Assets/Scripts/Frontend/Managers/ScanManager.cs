using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScanManager : ItemManager {

    // variables
    private int verificationTime = 5;

    // frame-by-frame functions
    private void Update()
    {
        // each frame, check to see if a qr code is being seen and act accordingly
    }

    // checkers
    private bool isQR() {
        // checks if the current image is a qr code
        return false;
    }

    private bool isValid() {
        // checks to see if the current qr code is valid
        return false;
    }

    IEnumerator verify() {
        // coroutine to check if the same qr code is held for verificationTime number of seconds
        return null;
    }
}

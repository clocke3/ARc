using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScanManager : ItemManager {

    private void Update()
    {
        // each frame, check to see if a qr code is being seen and act accordingly
    }

    private bool isQR() {
        // checks if the current image is a qr code
        return false;
    }

    private bool isValid() {
        // checks to see if the current qr code is valid
        return false;
    }

    IEnumerator verify() {
        // coroutine to check if the same qr code is held for a specified amount of time
        return null;
    }
}

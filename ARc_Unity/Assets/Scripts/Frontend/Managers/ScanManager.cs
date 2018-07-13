using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;

public class ScanManager : ItemManager
{

    //variables
    private DatabaseManager db;
    private string result;

    // frame-by-frame function
    private static Texture2D RotateTexture(Texture2D image)
    {
        //flip image width<>height, as we rotated the image, it might be a rect. not a square image
        Texture2D target = new Texture2D(image.height, image.width, image.format, false);
        Color32[] pixels = image.GetPixels32(0);
        pixels = RotateTextureGrid(pixels, image.width, image.height);
        target.SetPixels32(pixels);
        target.Apply();
        return target;
    }

    private static Color32[] RotateTextureGrid(Color32[] texture, int width, int height)
    {
        //reminder we are flipping these in the target
        Color32[] rotatedTexture = new Color32[width * height];

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                //juggle the pixels around
                rotatedTexture[(height - 1) - y + x * height] = texture[x + y * width];
            }
        }

        return rotatedTexture;
    }

    // checkers
    private bool isQR(Texture2D img)
    {
        // checks if the current image is a qr code
        for (int x = 0; x < img.width; x++)
            for (int y = 0; y < img.height; y++)
                if (!img.GetPixel(x, y).a.Equals(new Color(0, 0, 0, 255)) || !img.GetPixel(x, y).a.Equals(new Color(255, 255, 255, 255)))
                    return false;
        return true;
    }

    private bool isValid(Texture2D img)
    {
        // checks to see if the current qr code is valid
        // scan qr code for link
        if (isQR(img)) {
            BarcodeReader barcodeReader = new BarcodeReader();
            List<BarcodeFormat> possibleFormats = new List<BarcodeFormat>();
            possibleFormats.Add(BarcodeFormat.QR_CODE);
            barcodeReader.Options = new DecodingOptions()
            {
                PossibleFormats = possibleFormats,
                CharacterSet = "UTF-8",
                TryHarder = true
            };

            result = barcodeReader.Decode(img.GetPixels32(), img.width, img.height).ToString();
            //check database
            if (!db.containsCode(result))
            {
                // Try rotating the image. I know that QR codes don't care about orientation, but without this the scan fails often
                img = RotateTexture(img);
                result = barcodeReader.Decode(img.GetPixels32(), img.width, img.height).ToString();
            }
            if (db.containsCode(result))
            {
                getProfile();
                return true;
            }
            else{
                return false;
            }
        }
        return false;
    }


    public void getProfile()
    {
        updateCurrentCode(result);
        displayCodeProfile();
    }

 
}

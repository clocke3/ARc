using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Profiable : MonoBehaviour
{
    protected int typeID, galleryID;
    protected string qrID;

    private int getTypeID(){
        return typeID;
    }
    private int getGalleryID(){
        return galleryID;
    }
    private string getQRID(){
        return qrID;
    }
}


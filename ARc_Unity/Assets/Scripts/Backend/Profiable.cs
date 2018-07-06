using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Profiable : MonoBehaviour
{
    protected int typeID, galleryID;
    protected string qrID;

    public int getTypeID(){
        return typeID;
    }
    public int getGalleryID(){
        return galleryID;
    }
    public string getQRID(){
        return qrID;
    }
}


using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Profiable : MonoBehaviour
{
    protected int typeID, qrID, galleryID;

    private int getTypeID(){
        return typeID;
    }
    private int getQRID(){
        return qrID;
    }
    private int getGalleryID(){
        return galleryID;
    }
}


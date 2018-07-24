using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public abstract class Profiable : DatabaseObject
{

    // variables
    protected string qrID;
    protected MediaGallery gallery;
    protected Sprite locationImage;

    // constructors
    protected void profiableInit()
    {
        this.qrID = "";
        this.gallery = MediaGallery.CreateInstance();
        this.locationImage = null;
        this.databaseObjectInit();
    }

    protected void profiableInit(string label, string qrID,
                                 MediaGallery gallery, Sprite locationImage) {
        this.qrID = qrID;
        this.gallery = gallery;
        this.locationImage = locationImage;
        this.databaseObjectInit(label);
    }

    // getters
    public MediaGallery getGallery(){
        return gallery;
    }

    public string getQRID(){
        return qrID;
    }

    public Sprite getLocationImage() {
        return locationImage;
    }

    // comparison
    public bool equalQRID(string otherQRID) {
        return string.Equals(qrID, otherQRID);
    }
}


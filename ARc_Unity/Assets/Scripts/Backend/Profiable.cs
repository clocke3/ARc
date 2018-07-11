using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Profiable : DatabaseObject
{

    // variables
    protected string qrID;
    protected MediaGallery gallery;

    // constructors
    protected void profiableInit()
    {
        this.qrID = "";
        this.gallery = MediaGallery.CreateInstance();
        this.databaseObjectInit();
    }

    protected void profiableInit(string label, string qrID,
                        MediaGallery gallery) {
        this.qrID = qrID;
        this.gallery = gallery;
        this.databaseObjectInit(label);
    }

    // getters
    public MediaGallery getGallery(){
        return gallery;
    }

    public string getQRID(){
        return qrID;
    }

    // comparison
    public bool equalQRID(string otherQRID) {
        return string.Equals(qrID, otherQRID);
    }
}


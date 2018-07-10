using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Profiable : DatabaseObject
{

    // variables
    protected string qrID;
    protected MediaGallery gallery;

    // constructor
    protected Profiable(string label, string qrID, 
                        MediaGallery gallery) : base(label) {
        this.qrID = qrID;
        this.gallery = gallery;
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


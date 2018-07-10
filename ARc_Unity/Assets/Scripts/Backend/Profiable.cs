using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Profiable : DatabaseObject
{

    // variables
    public const int DEPARTMENT = 0, EMPLOYEE = 1;
    protected string qrID;
    protected int typeID;
    protected MediaGallery gallery;

    // constructor
    protected Profiable(string label, string qrID, 
                        MediaGallery gallery) : base(label) {
        this.qrID = qrID;
        this.gallery = gallery;
    }

    // setters
    protected abstract void setTypeID();

    // getters
    public int getTypeID(){
        return typeID;
    }

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


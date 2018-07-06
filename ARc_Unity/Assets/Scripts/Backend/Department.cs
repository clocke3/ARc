using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Department : Profiable
{
    private string name, description;
    private List<Division> divisions;

    public Department()
    {
        name = "";
        description = "";
        divisions = null;
    }

    public Department(string name, string description, List<Division> divisions)
    {
        this.name = name;
        this.description = description;
        this.divisions = divisions;
    }

    protected Department(int typeID, int qrID, int galleryID)
    {
        this.typeID = typeID;
        this.qrID = qrID;
        this.galleryID = galleryID;
    }

    public string getDescription()
    {
        return description;
    }
    public List<Division> getDivisions()
    {
        return divisions;
    }
    private string getName()
    {
        return name;
    }
    protected int getTypeID()
    {
        return typeID;
    }

    protected int getQRID()
    {
        return qrID;
    }
    protected int getGalleryID()
    {
        return galleryID;
    }
}

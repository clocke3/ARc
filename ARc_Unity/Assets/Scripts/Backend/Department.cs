﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

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

    public Department(string name, string description, List<Division> divisions, int typeID, string qrID, int galleryID)
    {
        this.name = name;
        this.description = description;
        this.divisions = divisions;
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
    public string getName()
    {
        return name;
    }

    public bool isEqual(Department other)
    {
        if (this.name != other.name)
            return false;

        if (this.description != other.description)
            return false;

        if (this.divisions.Count != other.divisions.Count)
            return false;
        if (this.typeID != other.typeID)
            return false;
        if (this.qrID != other.qrID)
            return false;
        if (this.galleryID != other.galleryID)
            return false;
        return true;
    }
   
}

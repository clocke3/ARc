using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Department : Profiable
{

    // variables
    private string description;
    private List<Division> divisions;

    // constructors
    public Department() : base("", "", new MediaGallery())
    {
        description = "";
        divisions = new List<Division>();
    }

    public Department(string label, string qrID, MediaGallery gallery, string description, List<Division> divisions) : base(label, qrID, gallery)
    {
        this.description = description;
        this.divisions = divisions;
    }

    // setters
    protected override void setTypeID()
    {
        this.typeID = DatabaseObject.DEPARTMENT;
    }

    // getters
    public string getDescription()
    {
        return description;
    }

    public List<Division> getDivisions()
    {
        return divisions;
    }
   
}

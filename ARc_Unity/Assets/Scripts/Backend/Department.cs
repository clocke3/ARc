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
    private void init() {
        description = "";
        divisions = new List<Division>();
        this.profiableInit();
    }

    private void init(string label, string qrID, MediaGallery gallery, string description, List<Division> divisions) {
        this.description = description;
        this.divisions = divisions;
        this.profiableInit(label, qrID, gallery);
    }

    public static Department CreateInstance()
    {
        Department department = CreateInstance<Department>();
        department.init();
        return department;
    }

    public static Department CreateInstance(string label, string qrID, MediaGallery gallery, string description, List<Division> divisions) {
        Department department = CreateInstance<Department>();
        department.init(label, qrID, gallery, description, divisions);
        return department;
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

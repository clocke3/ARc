using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DatabaseObject : ScriptableObject {

    // constants
    public const int DEPARTMENT = 0, DIVISION = 1, ROLE = 2, EMPLOYEE = 3, MEDIAGALLERY = 4;

    // variables
    protected string label;
    protected int typeID;

    // constructors
    protected void databaseObjectInit()
    {
        this.label = "";
        setTypeID();
    }

    protected void databaseObjectInit(string label) {
        this.label = label;
        setTypeID();
    }

    // setters
    protected abstract void setTypeID();

    // getters
    public string getLabel() {
        return label;
    }

    public int getTypeID() {
        return typeID;
    }

    // comparers
    public bool isEqual(DatabaseObject other) {
        return (this.typeID == other.typeID) && (this.label.Equals(other.label));
    }
}

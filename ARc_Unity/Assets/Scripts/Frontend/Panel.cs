using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Panel : MonoBehaviour {

    // variables
    protected ProfileManager profileManager;
    public DatabaseObjectButton databaseObjectButton;

    // setters
    public void setup(ProfileManager profileManager, DatabaseObject databaseObject) {
        this.profileManager = profileManager;
        setToRepresent(databaseObject);
        setAttributes();
    }

    protected abstract void setToRepresent(DatabaseObject databaseObject); // see if the object is compatible and if so set that up

    protected abstract void setAttributes(); // if there's an object to represent, then set up each attribute for visual profile

}

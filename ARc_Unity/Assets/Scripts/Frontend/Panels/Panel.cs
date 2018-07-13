using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Panel : MonoBehaviour {

    // variables
    protected ProfileManager profileManager;
    public DatabaseObjectButton databaseObjectButtonPrefab;
    public bool isOn = true;

    // setters
    public void setup(ProfileManager profileManager, DatabaseObject databaseObject) {
        this.profileManager = profileManager;
        this.transform.SetParent(profileManager.profilesHolder.transform, true);
        this.transform.SetSiblingIndex(0);
        setToRepresent(databaseObject);
        setAttributes();
    }

    protected abstract void setToRepresent(DatabaseObject databaseObject); // see if the object is compatible and if so set that up

    protected abstract void setAttributes(); // if there's an object to represent, then set up each attribute for visual profile

    // openers
    public void openObject(DatabaseObject databaseObject) {
        profileManager.addPanel(databaseObject);
    }

    // closer
    public void exit() {
        isOn = false;
        profileManager.updatePanels();
        Destroy(gameObject);
    }

}

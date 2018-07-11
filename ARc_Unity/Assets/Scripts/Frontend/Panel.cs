using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Panel : MonoBehaviour {

    // variables
    protected ProfileManager profileManager;
    private List<DatabaseObjectButton> databaseObjectButtons;
    public DatabaseObjectButton databaseObjectButtonPrefab;

    // setters
    public void setup(ProfileManager profileManager, DatabaseObject databaseObject) {
        this.profileManager = profileManager;
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
    public void exit()
    {
        Destroy(gameObject);
    }

}

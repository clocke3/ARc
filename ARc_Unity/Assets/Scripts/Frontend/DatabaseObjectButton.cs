using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseObjectButton : MonoBehaviour {

    private Panel panel;
    private DatabaseObject databaseObject;

    // setters
    public void setup(Panel panel, DatabaseObject databaseObject) {
        this.panel = panel;
        this.databaseObject = databaseObject;
    }

    // openers
    public void openPanel() {
        panel.openObject(databaseObject);
    }

}

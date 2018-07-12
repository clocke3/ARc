using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DatabaseObjectButton : MonoBehaviour {

    // variables
    private Panel panel;
    private DatabaseObject databaseObject;
    private Button button;

    // initialization
    private void Start()
    {
        button = this.gameObject.GetComponent<Button>();
    }

    // setters
    public void setup(Panel panel, DatabaseObject databaseObject) {
        button = this.gameObject.GetComponent<Button>();
        this.panel = panel;
        this.databaseObject = databaseObject;
        setText();
    }

    public void setText() {
        button.GetComponentInChildren<Text>().text = databaseObject.getLabel();
    }

    // openers
    public void openPanel() {
        panel.openObject(databaseObject);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DatabaseObjectButton : MonoBehaviour {

    private Panel panel;
    private DatabaseObject databaseObject;
    private Button button;

    // initialization
    private void Start()
    {
        databaseObject = Department.CreateInstance("FuckNuggets", "hello", MediaGallery.CreateInstance(), "poop", new List<Division>());
        button = this.gameObject.GetComponent<Button>();
        setText();
    }

    // setters
    public void setup(Panel panel, DatabaseObject databaseObject) {
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

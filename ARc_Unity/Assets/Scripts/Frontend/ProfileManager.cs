using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfileManager : MonoBehaviour {

    // variables
    private DatabaseManager databaseManager;
    public ItemManager itemManager;
    public List<GameObject> panels;

    // initialization
    void Start() {
        databaseManager = DatabaseManager.getInstance();
        this.gameObject.SetActive(false);
    }

    // clearing panels
    private void clearPanels() {
        panels.Clear();
    }

    public void back() {
        clearPanels();
        itemManager.gameObject.SetActive(true);
        this.gameObject.SetActive(false);
    }

    // adding panels
    public void addPanel(DatabaseObject databaseObject) {
        
    }

    public void displayProfile(string qrID) {
        addPanel(databaseManager.getProfiable(qrID));
    }

}

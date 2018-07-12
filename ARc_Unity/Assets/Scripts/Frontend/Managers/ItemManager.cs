using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemManager : MonoBehaviour {

    // variables
    protected DatabaseManager databaseManager;
    public ProfileManager profileManager;
    protected string currentCode;


    // constructor
    void Start() {
        databaseManager = DatabaseManager.getInstance();
    }

    // functions
    public void updateCurrentCode(string newCode) {
        currentCode = newCode;
    }

    public void displayCodeProfile() {
        profileManager.gameObject.SetActive(true);
        profileManager.displayProfile(currentCode);
        this.gameObject.SetActive(false);
    }

    public void displayProfile(DatabaseObject databaseObject) {
        profileManager.gameObject.SetActive(true);
        profileManager.addPanel(databaseObject);
        this.gameObject.SetActive(false);
    }

}

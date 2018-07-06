using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemManager : MonoBehaviour {

    // variables
    protected DatabaseManager databaseManager;
    public ProfileManager profileManager;
    protected string currentCode;


    // constructor
    private void Start() {
        databaseManager = DatabaseManager.getInstance();
    }

    // functions
    public void updateCurrentCode(string newCode) {
        currentCode = newCode;
    }

    public void displayCodeProfile() {
        profileManager.displayProfile(currentCode);
        this.gameObject.SetActive(false);
    }

}

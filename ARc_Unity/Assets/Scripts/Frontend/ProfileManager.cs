﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfileManager : MonoBehaviour {

    // variables
    private DatabaseManager databaseManager;
    public ItemManager itemManager;
    private List<Panel> panels;
    public Panel[] panelPrefabs = new Panel[5];

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
    public void addPanel(DatabaseObject databaseObject)
    {
        Panel newPanel;
        switch (databaseObject.getTypeID())
        {
            case DatabaseObject.DEPARTMENT:
                newPanel = Instantiate(panelPrefabs[DatabaseObject.DEPARTMENT], transform.position, Quaternion.identity) as Panel;
                break;
            case DatabaseObject.DIVISION:
                newPanel = Instantiate(panelPrefabs[DatabaseObject.DIVISION], transform.position, Quaternion.identity) as Panel;
                break;
            case DatabaseObject.ROLE:
                newPanel = Instantiate(panelPrefabs[DatabaseObject.ROLE], transform.position, Quaternion.identity) as Panel;
                break;
            case DatabaseObject.EMPLOYEE:
                newPanel = Instantiate(panelPrefabs[DatabaseObject.EMPLOYEE], transform.position, Quaternion.identity) as Panel;
                break;
            case DatabaseObject.MEDIAGALLERY:
                newPanel = Instantiate(panelPrefabs[DatabaseObject.MEDIAGALLERY], transform.position, Quaternion.identity) as Panel;
                break;
            default:
                return;
        }
        newPanel.setup(this, databaseObject);
        panels.Add(newPanel);
    }

    public void displayProfile(string qrID) {
        addPanel(databaseManager.getProfiable(qrID));
    }

}

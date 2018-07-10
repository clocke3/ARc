using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseManager : MonoBehaviour {

    // variables
    public static DatabaseManager instance = null;
    private static DatabaseObject database;         //database (FIX WHEN READY)
    private static List<Department> departments;

	// Initialization
	void Awake () {
        if (instance == null)
        {
            instance = this;
        }
        else Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

        // set up database variable
	}

    void Start() {
        dataToObjects();
    }


    // setters
    private void dataToObjects() {
        // translate database into database objects
        // (i.e. fill up departments variable)
        departments = new List<Department>();
    }

    // getters
    public static DatabaseManager getInstance() {
        return instance;
    }

    // finders
    public Profiable getProfiable(string qrID) {
        // search through departments and return the Profiable with the given qrID, or null if the qrID never comes up
        return new Department();
    }

    public bool containsCode(string qrID) {
        // search through departments and say whether or not qrID comes up
        return getProfiable(qrID) != null;
    }
	
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseManager : MonoBehaviour {

    // variables
    private static DatabaseManager instance = null;
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

    public static List<Profiable> search(string keyword) {
        // return a list of all departments and employees with a label featuring keyword
        return null;
    }

    public static List<Profiable> search(string keyword, int typeID) {

        return null;
    }

    // finders
    public Profiable getProfiable(string qrID) {
        // search through departments and return the Profiable with the given qrID, or null if the qrID never comes up
        return null;
    }

    public bool containsCode(string qrID) {
        // search through departments and say whether or not qrID comes up
        return getProfiable(qrID) != null;
    }
	
}

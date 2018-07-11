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

    // finders
    public Profiable getProfiable(string qrID) {
        // search through departments and return the Profiable with the given qrID, or null if the qrID never comes up
        Division division1 = Division.CreateInstance("Peter", null, null);
        Division division2 = Division.CreateInstance("Fin", null, null);
        List<Division> divisions = new List<Division>();
        divisions.Add(division1);
        divisions.Add(division2);
        Department department = Department.CreateInstance("fuckface", "hello", MediaGallery.CreateInstance(), "This department is a stupid buttface that is stupid and I hate it!", divisions);

        if (department.equalQRID(qrID)) return department;

        return null;
    }

    public bool containsCode(string qrID) {
        // search through departments and say whether or not qrID comes up
        return getProfiable(qrID) != null;
    }
	
}

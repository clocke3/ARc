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

        List<string> hobbies = new List<string>();
        hobbies.Add("existing");
        hobbies.Add("idk");
        hobbies.Add("y u still ask???");

        Employee employee1 = Employee.CreateInstance("Andrew", null, MediaGallery.CreateInstance(), null, hobbies);
        Employee employee2 = Employee.CreateInstance("Khalib", null, MediaGallery.CreateInstance(), null, hobbies);
        List<Employee> employees = new List<Employee>();
        employees.Add(employee1);
        employees.Add(employee2);

        Role role1 = Role.CreateInstance("Matthew", null, null);
        Role role2 = Role.CreateInstance("David", null, employees);
        List<Role> roles = new List<Role>();
        roles.Add(role1);
        roles.Add(role2);

        Division division1 = Division.CreateInstance("Peter", null, roles);
        Division division2 = Division.CreateInstance("Fin", null, null);
        List<Division> divisions = new List<Division>();
        divisions.Add(division1);
        divisions.Add(division2);

        Department department = Department.CreateInstance("face", "hello", MediaGallery.CreateInstance(), "This department is a stupid buttface that is stupid and I hate it!", divisions);

        foreach (Employee employee in employees)
        {
            employee.setRole(role2);
        }

        foreach (Role role in roles)
        {
            role.setDivision(division1);
        }

        foreach (Division division in divisions)
        {
            division.setDepartment(department);
        }

        if (department.equalQRID(qrID)) return department;

        return null;
    }

    public bool containsCode(string qrID) {
        // search through departments and say whether or not qrID comes up
        return getProfiable(qrID) != null;
    }
	
}

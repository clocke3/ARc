using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite; 
using System.Data; 
using System;

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

    void Start () {
    string conn = "URI=file:" + Application.dataPath + "/test.db"; //Path to database.
     IDbConnection dbconn;
     dbconn = (IDbConnection) new SqliteConnection(conn);
     dbconn.Open(); //Open connection to the database.
     IDbCommand dbcmd = dbconn.CreateCommand();
     string sqlQuery = "SELECT LAST_NAME,FIRST_NAME,POSITION " + "FROM EMPLOYEE";
     dbcmd.CommandText = sqlQuery;
     IDataReader reader = dbcmd.ExecuteReader();
     while (reader.Read())
     {
         string in_name = reader.GetString(0)+reader.GetString(1);
         string pos = reader.GetString(2);
        
         Debug.Log("  name ="+in_name+"  position ="+  pos);
     }
     reader.Close();
     reader = null;
     dbcmd.Dispose();
     dbcmd = null;
     dbconn.Close();
     dbconn = null;

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

    public List<Profiable> search(string keyword) {
        // return a list of all departments and employees with a label featuring keyword
        List<Profiable> profiables = new List<Profiable>();

        foreach (Department department in departments)
        {
            if (department.getLabel().Contains(keyword))
            {
                profiables.Add(department);
            }

            if (department.getDivisions() == null) continue;
            foreach (Division division in department.getDivisions())
            {
                if (division.getRoles() == null) continue;
                foreach (Role role in division.getRoles())
                {
                    if (role.getEmployees() == null) continue;
                    foreach (Employee employee in role.getEmployees())
                    {
                        if (employee.getLabel().Contains(keyword))
                        {
                            profiables.Add(employee);
                        }
                    }
                }
            }
        }

        return profiables;
    }

    public List<Profiable> search(string keyword, int typeID) {
        // return a list of all departments/employees (determined by typeID) with labels containing keyword
        List<Profiable> profiables = new List<Profiable>();

        if(typeID == DatabaseObject.DEPARTMENT) {
            foreach (Department department in departments)
            {
                if(department.getLabel().Contains(keyword)) {
                    profiables.Add(department);
                }
            }

        } else if(typeID == DatabaseObject.EMPLOYEE) {

            foreach (Department department in departments)
            {
                if (department.getDivisions() == null) continue;
                foreach (Division division in department.getDivisions())
                {
                    if (division.getRoles() == null) continue;
                    foreach (Role role in division.getRoles())
                    {
                        if (role.getEmployees() == null) continue;
                        foreach (Employee employee in role.getEmployees())
                        {
                            if (employee.getLabel().Contains(keyword))
                            {
                                profiables.Add(employee);
                            }
                        }
                    }
                }
            }
        }

        return profiables;
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

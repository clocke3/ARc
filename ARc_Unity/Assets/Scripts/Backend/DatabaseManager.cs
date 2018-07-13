﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite; 
using System.Data; 
using System;

public class DatabaseManager : MonoBehaviour {

    // variables
    private static DatabaseManager instance = null;       //database (FIX WHEN READY)
    private static List<Department> departments;
    //remove after
    private static List<Employee> employee;

	// Initialization
	void Awake () {
        if (instance == null)
        {
            instance = this;
        }
        else Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
        departments = new List<Department>();
        employee = new List<Employee>();
	}

    void Start()
    {
        string conn = "URI=file:" + Application.dataPath + "/test.db"; //Path to database.
        IDbConnection dbconn;
        dbconn = (IDbConnection)new SqliteConnection(conn);
        dbconn.Open(); //Open connection to the database.
        IDbCommand dbcmd = dbconn.CreateCommand();
        string sqlQuery = "SELECT QR_ID,LAST_NAME,FIRST_NAME,POSITION,DIVISION," +
               "WORK_DURATION,HOBBIES " + "FROM EMPLOYEE";
        dbcmd.CommandText = sqlQuery;
        IDataReader reader = dbcmd.ExecuteReader();
        while (reader.Read())
        {
            string qrid = reader.GetString(0);
            string in_name = reader.GetString(1) + "," + reader.GetString(2);
            string pos = reader.GetString(3);
            string dep = reader.GetString(4);
            string dur = reader.GetString(5);
            string hob = reader.GetString(6);
            Department b = Department.CreateInstance(dep, qrid, null, null, null);
            if (!(departments.Contains(b)))
            {
<<<<<<< HEAD
                departments.Add(b);
                foreach (Department find in departments)
                {
                    if (b.isEqual(find))
                    {
                        break;
                    }
                    else
                    {
                        departments.Add(b);
                    }
                }
                Employee e = Employee.CreateInstance(in_name, qrid, null, null, hob);
                if (!(employees.Contains(e)))
                {
                    employees.Add(e);
                }
                //Debug.Log("qr =" + qrid + "name = " + in_name + "  position = " + pos +
                //          "hob=" + hob);
                //Debug.Log(e.getHobbies());
            }
            reader.Close();
            reader = null;
            dbcmd.Dispose();
            dbcmd = null;
            dbconn.Close();
            dbconn = null;


            foreach (Department department in departments)
            {
                Debug.Log(department.getLabel());
            }
            foreach (Employee employee in employees)
            {
                Debug.Log(employee.getLabel());
=======
                departments.Add(b);
            }
            Employee e = Employee.CreateInstance(in_name, qrid, null, null, hob);
<<<<<<< HEAD
            if (!(employees.Contains(e)))
            {
                employees.Add(e);
>>>>>>> parent of 6487d6d... Merge branch 'master' of https://github.com/clocke3/ARc
            }
        }
    }
=======
            if (!(employee.Contains(e))){
                employee.Add(e);
            }
         Debug.Log("qr ="+qrid+"name = "+in_name+"  position = "+  pos +
                   "hob="+ hob);
            Debug.Log(e.getHobbies());
     }
     reader.Close();
     reader = null;
     dbcmd.Dispose();
     dbcmd = null;
     dbconn.Close();
     dbconn = null;
 }
>>>>>>> parent of e090992... set up search functions in DatabaseManager

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
<<<<<<< HEAD
                if (department.getLabel().Contains(keyword))
                {
                    Debug.Log(department.getLabel() + " and " + keyword);
                    profiables.Add(department);
                }
=======
                profiables.Add(department);
>>>>>>> parent of e090992... set up search functions in DatabaseManager
            }

            if (department.getDivisions() == null) continue;
            foreach (Division division in department.getDivisions())
            {
                if (division.getRoles() == null) continue;
                foreach (Role role in division.getRoles())
                {
<<<<<<< HEAD
                    Debug.Log(employee.getLabel() + " and " + keyword);
                    profiables.Add(employee);
=======
                    if (role.getEmployees() == null) continue;
                    foreach (Employee employee in role.getEmployees())
                    {
                        if (employee.getLabel().Contains(keyword))
                        {
                            profiables.Add(employee);
                        }
                    }
>>>>>>> parent of e090992... set up search functions in DatabaseManager
                }
            }
        }

        return profiables;
    }

    public List<Profiable> search(string keyword, int typeID) {
        // return a list of all departments/employees (determined by typeID) with labels containing keyword
        Debug.Log(keyword);

        List<Profiable> profiables = new List<Profiable>();

<<<<<<< HEAD
        if (typeID == DatabaseObject.DEPARTMENT)
        {
            if (departments != null)
            {
                foreach (Department department in departments)
                {
                    if (department.getLabel().ToLower().Contains(keyword.ToLower()))
                    {
                        Debug.Log(department.getLabel() + " and " + keyword);
                        profiables.Add(department);
                    }
=======
        if(typeID == DatabaseObject.DEPARTMENT) {
            foreach (Department department in departments)
            {
                if(department.getLabel().Contains(keyword)) {
                    profiables.Add(department);
>>>>>>> parent of e090992... set up search functions in DatabaseManager
                }
            }

        } else if(typeID == DatabaseObject.EMPLOYEE) {
<<<<<<< HEAD
            if (employees != null)
            {
                foreach (Employee employee in employees)
                {
                    if (employee.getLabel().ToLower().Contains(keyword.ToLower()))
                    {
                        Debug.Log(employee.getLabel() + " and " + keyword);
                        profiables.Add(employee);
                    }
=======

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
>>>>>>> parent of e090992... set up search functions in DatabaseManager
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

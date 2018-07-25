﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.SceneManagement;

public class DatabaseManager : MonoBehaviour
{
    
    // variables
    private static DatabaseManager instance = null;       //database (FIX WHEN READY)
    private static List<Department> departments;
    //remove after
    public static List<Employee> employees;

    // Initialization

    //private void OnEnable()
    //{
    //    addMock();
    //}

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else Destroy(gameObject);
        //DontDestroyOnLoad(gameObject);
        departments = new List<Department>();
        employees = new List<Employee>();

        addMock();
    }

    void Start()
    {
        //string conn = "URI=file:" + Application.dataPath + "/test.db"; //Path to database.
        //IDbConnection dbconn;
        //dbconn = (IDbConnection)new SqliteConnection(conn);
        //dbconn.Open(); //Open connection to the database.
        //IDbCommand dbcmd = dbconn.CreateCommand();
        //string sqlQuery = "SELECT QR_ID,LAST_NAME,FIRST_NAME,POSITION,DIVISION," +
        //       "WORK_DURATION,HOBBIES " + "FROM EMPLOYEE";
        //dbcmd.CommandText = sqlQuery;
        //IDataReader reader = dbcmd.ExecuteReader();
        //while (reader.Read())
        //{
        //    string qrid = reader.GetString(0);
        //    string in_name = reader.GetString(1) + "," + reader.GetString(2);
        //    string pos = reader.GetString(3);
        //    string dep = reader.GetString(4);
        //    string dur = reader.GetString(5);
        //    string hob = reader.GetString(6);

        //    bool isNew = true;
        //    Department b = Department.CreateInstance(dep, qrid, null, null, null, null);
        //    foreach (Department find in departments)
        //    {
        //        if (b.isEqual(find))
        //        {
        //            isNew = false;
        //            break;
        //        }
        //    }
        //    if(isNew) departments.Add(b);

        //    isNew = true;
        //    Employee e = Employee.CreateInstance(in_name, qrid, null, null, null, hob);
        //    foreach (Employee find in employees)
        //    {
        //        if (e.isEqual(find))
        //        {
        //            isNew = false;
        //            break;
        //        }
        //    }
        //    if (isNew) employees.Add(e);

        //    //Debug.Log("qr =" + qrid + "name = " + in_name + "  position = " + pos +
        //    //          "hob=" + hob);
        //    //Debug.Log(e.getHobbies());
        //}
        //reader.Close();
        //reader = null;
        //dbcmd.Dispose();
        //dbcmd = null;
        //dbconn.Close();
        //dbconn = null;
    }

    //bool hasMocked = false;
    private void addMock() {
        //if (hasMocked) return;
        //hasMocked = true;

        MediaGallery gallery1 = MediaGallery.CreateInstance(null, null);
        MediaGallery gallery2 = MediaGallery.CreateInstance(null, null);

        string hobbies = "running, being cool, bongos";

        Employee employee1 = Employee.CreateInstance("Donkey Kong", "34FEN3NIV", null, null, null, hobbies);
        Employee employee2 = Employee.CreateInstance("Mario", null, gallery1, null, null, null);
        gallery1.setProfiable(employee2);
        List<Employee> employeesList = new List<Employee>();
        employeesList.Add(employee1);
        employeesList.Add(employee2);

        employees.Add(employee1);
        employees.Add(employee2);

        Role role1 = Role.CreateInstance("Developers", null, null);
        Role role2 = Role.CreateInstance("PM", null, employeesList);
        List<Role> roles = new List<Role>();
        roles.Add(role1);
        roles.Add(role2);

        Division division1 = Division.CreateInstance("Application Development", null, roles);
        Division division2 = Division.CreateInstance("Finances", null, null);
        List<Division> divisions = new List<Division>();
        divisions.Add(division1);
        divisions.Add(division2);

        Department department = Department.CreateInstance("Utilities", "hello", gallery2, null, "This department is a department is a department is a department is a department!", divisions);

        gallery2.setProfiable(department);

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

        departments.Add(department);

    }

    //private void OnLevelWasLoaded(int level)
    //{
    //    Start();
    //    addMock();

    //}

    // getters
    public static DatabaseManager getInstance()
    {
        return instance;
    }

    public List<Profiable> search(string keyword)
    {
        // return a list of all departments and employees with a label featuring keyword
        List<Profiable> profiables = new List<Profiable>();

        if (departments != null)
        {
            foreach (Department department in departments)
            {
                //Debug.Log(department.getLabel());
                if (department.getLabel().ToLower().Contains(keyword.ToLower()))
                {
                    profiables.Add(department);
                }
            }
        }
        if (employees != null)
        {
            foreach (Employee employee in employees)
            {
                //Debug.Log(employee.getLabel());
                if (employee.getLabel().ToLower().Contains(keyword.ToLower()))
                {
                    profiables.Add(employee);
                }
            }
        }

        //foreach (Department department in departments)
        //{
        //    if (department.getLabel().Contains(keyword))
        //    {
        //        profiables.Add(department);
        //    }

        //    if (department.getDivisions() == null) continue;
        //    foreach (Division division in department.getDivisions())
        //    {
        //        if (division.getRoles() == null) continue;
        //        foreach (Role role in division.getRoles())
        //        {
        //            if (role.getEmployees() == null) continue;
        //            foreach (Employee employee in role.getEmployees())
        //            {
        //                if (employee.getLabel().Contains(keyword))
        //                {
        //                    profiables.Add(employee);
        //                }
        //            }
        //        }
        //    }
        //}

        return profiables;
    }

    public List<Profiable> search(string keyword, int typeID)
    {
        // return a list of all departments/employees (determined by typeID) with labels containing keyword
        List<Profiable> profiables = new List<Profiable>();

        if (typeID == DatabaseObject.DEPARTMENT)
        {
            if (departments != null)
            {
                foreach (Department department in departments)
                {
                    if (department.getLabel().ToLower().Contains(keyword.ToLower()))
                    {
                        profiables.Add(department);
                    }
                }
            }
        }
        else if (typeID == DatabaseObject.EMPLOYEE)
        {
            if (employees != null)
            {
                foreach (Employee employee in employees)
                {
                    if (employee.getLabel().ToLower().Contains(keyword.ToLower()))
                    {
                        profiables.Add(employee);
                    }
                }
            }
        }


        //if(typeID == DatabaseObject.DEPARTMENT) {
        //    foreach (Department department in departments)
        //    {
        //        if(department.getLabel().Contains(keyword)) {
        //            profiables.Add(department);
        //        }
        //    }

        //} else if(typeID == DatabaseObject.EMPLOYEE) {

        //    foreach (Department department in departments)
        //    {
        //        if (department.getDivisions() == null) continue;
        //        foreach (Division division in department.getDivisions())
        //        {
        //            if (division.getRoles() == null) continue;
        //            foreach (Role role in division.getRoles())
        //            {
        //                if (role.getEmployees() == null) continue;
        //                foreach (Employee employee in role.getEmployees())
        //                {
        //                    if (employee.getLabel().Contains(keyword))
        //                    {
        //                        profiables.Add(employee);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        return profiables;
    }

    // finders
    public Profiable getProfiable(string qrID)
    {
        // search through departments and return the Profiable with the given qrID, or null if the qrID never comes up

        if (departments != null)
        {
            foreach (Department department in departments)
            {
                if (department.equalQRID(qrID))
                {
                    return department;
                }
            }
        }
        if (employees != null)
        {
            foreach (Employee employee in employees)
            {
                if (employee.equalQRID(qrID))
                {
                    return employee;
                }
            }
        }

        return null;
    }

    public bool containsCode(string qrID)
    {
        // search through departments and say whether or not qrID comes up
        return getProfiable(qrID) != null;
    }
}
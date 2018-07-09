﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivisionTest : MonoBehaviour {

    // run tests on Start
    private void Start() {
        if(!testConstructor()) {
            Debug.Log("CONSTRUCTOR FAIL");
        }

        if (!testGetName())
        {
            Debug.Log("GETNAME FAIL");
        }

        if (!testGetDepartment())
        {
            Debug.Log("GETDEPARTMENT FAIL");
        }

        if (!testGetRoles())
        {
            Debug.Log("GETROLES FAIL");
        }

        if (!testIsEqual())
        {
            Debug.Log("ISEQUAL FAIL");
        }
    }


    // test constructor
    public bool testConstructor() {
        string name = "test division";
        Department department = new Department();
        List<Role> roles = new List<Role>();

        Division division = new Division(name, department, roles);

        if (name != division.name) {
            return false;
        }

        if(!department.isEqual(division.getDepartment())) {
            return false;
        }

        if (!roles.Equals(division.getRoles())) {
            return false;
        }

        return true;
    }


    // test functions
    //      getters
    public bool testGetName() {
        string name = "test division";

        Division division = new Division(name, null, null);

        if (name == division.getName()) return false;

        return true;
    }

    public bool testGetDepartment()
    {
        Department department = new Department();

        Division division = new Division(null, department, null);

        if (!department.isEqual(division.getDepartment())) return false;

        return true;
    }

    public bool testGetRoles()
    {
        List<Role> roles = new List<Role>();

        Division division = new Division(null, null, roles);

        if (!roles.Equals(division.getRoles())) return false;

        return true;
    }

    //      comparison
    public bool testIsEqual() {
        string name = "test division";
        Department department = new Department();
        List<Role> roles = new List<Role>();

        Division division1 = new Division(name, department, roles);
        Division division2 = new Division(name, department, roles);

        if(!division1.isEqual(division2)) return false;

        return true;
    }

}

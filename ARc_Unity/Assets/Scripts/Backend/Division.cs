using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Division : DatabaseObject {

    // variables
    private Department department;
    private List<Role> roles;

    // constructors
    private void init()
    {
        department = Department.CreateInstance();
        roles = new List<Role>();
        this.databaseObjectInit();
    }

    private void init(string label, Department department, List<Role> roles)
    {
        this.department = department;
        this.roles = roles;
        this.databaseObjectInit(label);
    }

    public static Division CreateInstance()
    {
        Division division = CreateInstance<Division>();
        division.init();
        return division;
    }

    public static Division CreateInstance(string label, Department department, List<Role> roles)
    {
        Division division = CreateInstance<Division>();
        division.init(label, department, roles);
        return division;
    }

    // setters
    protected override void setTypeID()
    {
        this.typeID = DatabaseObject.DIVISION;
    }

    public void setRole(List<Role> roles)
    {
        this.roles = roles;
    }

    public void setDepartment(Department department) {
        this.department = department;
    }

    // getters
    public Department getDepartment() {
        return department;
    }

    public List<Role> getRoles() {
        return roles;
    }


}

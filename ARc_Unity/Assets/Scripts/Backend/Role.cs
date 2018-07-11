using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Role : DatabaseObject {

    // variables
    private Division division;
    private List<Employee> employees; 

    // constructors
    private void init()
    {
        division = Division.CreateInstance();
        employees = new List<Employee>();
        this.databaseObjectInit();
    }

    private void init(string label, Division division, List<Employee> employees)
    {
        this.division = division;
        this.employees = employees;
        this.databaseObjectInit(label);
    }

    public static Role CreateInstance()
    {
        Role role = CreateInstance<Role>();
        role.init();
        return role;
    }

    public static Role CreateInstance(string label, Division division, List<Employee> employees)
    {
        Role role = CreateInstance<Role>();
        role.init(label, division, employees);
        return role;
    }

    // setters
    protected override void setTypeID()
    {
        this.typeID = DatabaseObject.ROLE;
    }

    // getters
    public Division getDivision() {
        return division; 
    }

    public List<Employee> getEmployees() {
        return employees; 
    }


}

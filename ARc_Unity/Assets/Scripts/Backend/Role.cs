using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Role : DatabaseObject {

    // variables
    private Division division;
    private List<Employee> employees; 

    // constructors
    public Role() : base("") {
        division = new Division();
        employees = new List<Employee>();
    }

    public Role(string label, Division division, List<Employee> employees) : base(label)
    {
        this.division = division;
        this.employees = employees;
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

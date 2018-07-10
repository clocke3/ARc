using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Role : DatabaseObject {

    List<Employee> employees; 
    Division division;

    public Role() {
        label = null;
        employees = null;
        division = null;
    }

    public Role(string name, Division division, List<Employee> employees)
    {
        this.label = name;
        this.division = division;
        this.employees = employees; 

    }

    public string getName() {
        return label; 
    }

    public Division getDivision() {
        return division; 
    }

    public List<Employee> getEmployees() {
        return employees; 
    }



}

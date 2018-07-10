using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Role : MonoBehaviour {

    string label;
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

     public bool isEqual(Role role) {
        if (this.label != role.label) return false;

        if (!this.division.isEqual(role.division)) return false;

        if (this.employees.Count != role.employees.Count) return false;

        for (int i = 0; i < this.employees.Count; i++) {
            if (!this.employees[i].isEqual(role.employees[i])) return false;
        }

        return true;
    }


}

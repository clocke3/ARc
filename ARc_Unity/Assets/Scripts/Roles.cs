using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Role : MonoBehaviour {

    string Name;
    List<Employee> employees; 
    Division division;

    public Role() {
        
    }

    public Role(string name, Division division, List<Employee> employees)
    {
        Name = name;
        Division Division = division;
        List<Employee> Employee = employees; 

    }

    public string getName() {
        Name = name; 
    }

    public Division getDivision() {
        Division Division = division;
    }

    public List<Employee> getEmployees() {
        List<Employee> Employee = employees;
    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Division : MonoBehaviour {

    // data
    private string name;
    private Department department;
    private List<Role> roles;


    // constructor
    public Division(string name, Department department, List<Role> roles) {
        this.name = name;
        this.department = department;
        this.roles = roles;
    }


    // getters
    public string getName() {
        return name;
    }

    public Department getDepartment() {
        return department;
    }

    public List<Role> getRoles() {
        return roles;
    }

}

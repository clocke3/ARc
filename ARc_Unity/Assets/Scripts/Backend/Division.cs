using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Division : DatabaseObject {

    // data
    private Department department;
    private List<Role> roles;


    // constructors
    public Division(){
        label = "";
        department = null;
        roles = null;
    }

    public Division(string name, Department department, List<Role> roles) {
        this.label = name;
        this.department = department;
        this.roles = roles;
    }


    // getters
    public string getName() {
        return label;
    }

    public Department getDepartment() {
        return department;
    }

    public List<Role> getRoles() {
        return roles;
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Division : MonoBehaviour {

    // data
    private string label;
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


    // comparison
    public bool isEqual(Division other) {
        if (this.label != other.label) return false;

        if (!this.department.isEqual(other.department)) return false;

        if (this.roles.Count != other.roles.Count) return false;

        for (int i = 0; i < this.roles.Count; i++) {
            if (!this.roles[i].isEqual(other.roles[i])) return false;
        }

        return true;
    }

}

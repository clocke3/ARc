using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Division : DatabaseObject {

    // variables
    private Department department;
    private List<Role> roles;


    // constructors
    public Division() : base("") {
        department = new Department();
        roles = new List<Role>();
    }

    public Division(string label, Department department, List<Role> roles) : base(label) {
        this.department = department;
        this.roles = roles;
    }

    // setters
    protected override void setTypeID()
    {
        this.typeID = DatabaseObject.DIVISION;
    }

    // getters
    public Department getDepartment() {
        return department;
    }

    public List<Role> getRoles() {
        return roles;
    }


}

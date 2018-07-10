using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Employee : Profiable
{
    // variables
    private Role role;
    private List<string> hobbies;

    // constructors
    public Employee() : base("", "", new MediaGallery()){
        role = new Role();
        hobbies = new List<string>();
    }

    public Employee (string label, string qrID, MediaGallery gallery, Role role, List<string> hobbies) : base(label, qrID, gallery){
        this.role = role;
        this.hobbies = hobbies;
    }

    // setters
    protected override void setTypeID()
    {
        this.typeID = DatabaseObject.EMPLOYEE;
    }

    // getters
    public Role getRole(){
        return role;
    }

    public List<string> getHobbies(){
        return hobbies;
    }

   
} 

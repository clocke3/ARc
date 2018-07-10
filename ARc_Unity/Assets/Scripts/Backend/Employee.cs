using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Employee : Profiable
{
    // variables
    private Role role;
    private List<string> hobbies;

    // constructors
    public Employee(){
        label = "";
        role = new Role();
        department = new Department();
        division = new Division();
        workDuration = 0;
        hobbies = new List<string>();
        typeID = 0;
        qrID = "";
        galleryID = 0;
    }

    public Employee (string name, Role position, Department department, Division division, int workDuration, List<string> hobbies, int typeId, string qrID, int galleryID){
        this.label = name;
        this.role = position;
        this.department = department;
        this.division = division;
        this.workDuration = workDuration;
        this.hobbies = hobbies;
        this.typeID = typeId;
        this.qrID = qrID;
        this.galleryID = galleryID;
    }

    public Department getDepartment(){
        return department;
    }
    public Division getDivision(){
        return division;
    }
    public string getName(){
        return label;
    }
    public Role getPosition(){
        return role;
    }
    public string getworkDuration(){
        return workDuration.ToString();
    }
    public List<string> getHobbies(){
        return hobbies;
    }

   
} 

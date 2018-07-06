using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Employee : Profiable
{
    private string name;
    private Role position;
    private Department department;
    private Division division;
    private int workDuration;
    private List<string> hobbies;

    public Employee(){
        name = "";
        position = "";
        department = null;
        division = null;
        workDuration = 0;
        hobbies = null;
        typeID = 0;
        qrID = null;
        galleryID = 0;
    }

    public Employee (string name, Role position, Department department, Division division, int workDuration, List<string> hobbies, int typeId, string qrID, int galleryID){
        this.name = name;
        this.position = position;
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
        return name;
    }
    public Role getPosition(){
        return position;
    }
    public string getworkDuration(){
        return workDuration.ToString();
    }
    public List<string> getHobbies(){
        return hobbies;
    }

    public bool isEqual(Employee other)
    {
        if (this.name != other.name)
            return false;

        if (!this.department.isEqual(other.department))
            return false;

        if (this.position != other.position)
            return false;
        if (this.typeID != other.typeID)
            return false;
        if (this.qrID != other.qrID)
            return false;
        if (this.galleryID != other.galleryID)
            return false;
        if (this.division != other.division)
            return false;
        if (this.workDuration != other.workDuration)
            return false;
        if (this.hobbies.Count != other.hobbies.Count)
            return false;
        return true;
    }
   
} 

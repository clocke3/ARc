using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Employee : Profiable
{
    private string name, position;
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
    }

    public Employee (string name, string position, Department department, Division division, int workDuration, List<string> hobbies){
        this.name = name;
        this.position = position;
        this.department = department;
        this.division = division;
        this.workDuration = workDuration;
        this.hobbies = hobbies;
    }

    protected Employee (int typeId, int qrID, int galleryID){
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
    private string getName(){
        return name;
    }
    private string getPosition(){
        return position;
    }
    private string getworkDuration(){
        return workDuration.ToString();
    }
    private List<string> getHobbies(){
        return hobbies;
    }

    protected int getTypeID(){
        return typeID;
    }

    protected int getQRID(){
        return qrID;
    }
    protected int getGalleryID(){
        return galleryID;
    }
} 

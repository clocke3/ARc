using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Employee : Profiable
{
    // variables
    private Role role;
    private string hobbies;

    // constructors
    private void init()
    {
        role = Role.CreateInstance();
        hobbies = "";
        this.profiableInit();
    }

    private void init(string label, string qrID, MediaGallery gallery, Sprite locationImage, Role role, string hobbies)
    {
        this.role = role;
        this.hobbies = hobbies;
        this.profiableInit(label, qrID, gallery, locationImage);
    }

    public static Employee CreateInstance()
    {
        Employee employee = CreateInstance<Employee>();
        employee.init();
        return employee;
    }

    public static Employee CreateInstance(string label, string qrID, MediaGallery gallery, Sprite locationImage, Role role, string hobbies)
    {
        Employee employee = CreateInstance<Employee>();
        employee.init(label, qrID, gallery, locationImage, role, hobbies);
        return employee;
    }

    // setters
    protected override void setTypeID()
    {
        this.typeID = DatabaseObject.EMPLOYEE;
    }

    public void setMediaGallery(MediaGallery gallery)
    {
        this.gallery = gallery;
    }

    public void setRole(Role role) {
        this.role = role;
    }

    // getters
    public Role getRole(){
        return role;
    }

    public string getHobbies(){
        return hobbies;
    }

   
} 

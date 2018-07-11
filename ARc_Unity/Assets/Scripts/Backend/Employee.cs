using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Employee : Profiable
{
    // variables
    private Role role;
    private List<string> hobbies;

    // constructors
    private void init()
    {
        role = Role.CreateInstance();
        hobbies = new List<string>();
        this.profiableInit();
    }

    private void init(string label, string qrID, MediaGallery gallery, Role role, List<string> hobbies)
    {
        this.role = role;
        this.hobbies = hobbies;
        this.profiableInit(label, qrID, gallery);
    }

    public static Employee CreateInstance()
    {
        Employee employee = CreateInstance<Employee>();
        employee.init();
        return employee;
    }

    public static Employee CreateInstance(string label, string qrID, MediaGallery gallery, Role role, List<string> hobbies)
    {
        Employee employee = CreateInstance<Employee>();
        employee.init(label, qrID, gallery, role, hobbies);
        return employee;
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

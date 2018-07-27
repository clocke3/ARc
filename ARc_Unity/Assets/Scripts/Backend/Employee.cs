using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Employee : Profiable
{
    // variables
    private Role role;
    private string hobbies;
    private string email;
    private Sprite profilePic;

    // constructors
    private void init()
    {
        role = Role.CreateInstance();
        hobbies = "";
        email = "";
        profilePic = null;
        this.profiableInit();
    }

    private void init(string label, string qrID, MediaGallery gallery, Sprite locationImage, Role role, string hobbies, string email, Sprite profilePic)
    {
        this.role = role;
        this.hobbies = hobbies;
        this.email = email;
        this.profilePic = profilePic;
        this.profiableInit(label, qrID, gallery, locationImage);
    }

    public static Employee CreateInstance()
    {
        Employee employee = CreateInstance<Employee>();
        employee.init();
        return employee;
    }

    public static Employee CreateInstance(string label, string qrID, MediaGallery gallery, Sprite locationImage, Role role, string hobbies, string email, Sprite profilePic)
    {
        Employee employee = CreateInstance<Employee>();
        employee.init(label, qrID, gallery, locationImage, role, hobbies, email, profilePic);
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

    public string getEmail() {
        return email;
    }

    public Sprite getProfilePic() {
        return profilePic;
    }

    public Division getDivision() {
        return role.getDivision();
    }
   
    public Department getDepartment()
    {
        return role.getDivision().getDepartment();
    }

} 

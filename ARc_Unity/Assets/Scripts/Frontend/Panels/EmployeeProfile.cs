using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmployeeProfile : Panel
{
    // variables
    private Employee employee;
    public Text label;
    public DatabaseObjectButton roleButton;
    public DatabaseObjectButton galleryButton;
    public DatabaseObjectButton divisionButton;
    public DatabaseObjectButton departmentButton;
    public GameObject hobbiesParent;
    public Text hobbiesText;
    public Text textPrefab;
    public LocationButton locationButton;
    public Text emailText;
    public Image profilePic;

    // panel stuff
    protected override void setToRepresent(DatabaseObject databaseObject)
    {
        if (databaseObject is Employee) employee = databaseObject as Employee;
    }

    protected override void setAttributes()
    {
        // set up employee label
        label.text = employee.getLabel();

        // set up role button
        if (employee.getRole() != null)
        {
            roleButton.setup(this, employee.getRole());
        }

        // set up gallery button
        if (employee.getGallery() != null)
        {
            galleryButton.setup(this, employee.getGallery());
        }

        // set up divisionButton
        if (employee.getDivision() != null)
        {
            divisionButton.setup(this, employee.getDivision());
        }

        // set up departmentButton
        if (employee.getDepartment() != null)
        {
            departmentButton.setup(this, employee.getDepartment());
        }


        // set up hobbies
        if (employee.getHobbies() != null && !employee.getHobbies().Equals(""))
        {
            hobbiesText.text = employee.getHobbies();
        } else {
            hobbiesText.text = "N/A";
        }

        // set up location button
        locationButton.setup(profileManager, employee.getLocationImage());

        // set up email text
        if (employee.getEmail() != null)
        {
            emailText.text = employee.getEmail();
        }

        // set up profile pic
        if (employee.getProfilePic() != null)
        {
            profilePic.sprite = employee.getProfilePic();
        } else {
            profilePic.sprite = Resources.Load<Sprite>("Sprites/GallerySprites/Default");
        }

    }
}
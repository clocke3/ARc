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
    public GameObject hobbiesParent;
    public Text hobbiesText;
    public Text textPrefab;
    public LocationButton locationButton;
    public Text emailText;

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

        // set up hobbies
        if (employee.getHobbies() != null)
        {
            hobbiesText.text = employee.getHobbies();
        }

        // set up location button
        if(employee.getLocationImage() != null) {
            locationButton.setup(profileManager, employee.getLocationImage());
        }

        // set up email text
        if(employee.getEmail() != null) {
            emailText.text = employee.getEmail();
        }

    }
}

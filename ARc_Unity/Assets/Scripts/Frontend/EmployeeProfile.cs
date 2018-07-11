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
    public Text textPrefab;

    // panel stuff
    protected override void setToRepresent(DatabaseObject databaseObject)
    {
        if (databaseObject is Employee) employee = databaseObject as Employee;
        else employee = null;
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
            List<string> hobbies = employee.getHobbies();
            foreach (string hobby in hobbies)
            {
                Text hobbyText = Instantiate(textPrefab, transform.position, Quaternion.identity) as Text;
                hobbyText.text = "#\t" + hobby;
                hobbyText.transform.SetParent(hobbiesParent.transform, true);
            }
        }
    }
}

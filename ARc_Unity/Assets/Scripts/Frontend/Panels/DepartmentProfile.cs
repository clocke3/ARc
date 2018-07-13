using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DepartmentProfile : Panel {

    // variables
    private Department department;
    public Text label;
    public Text description;
    public DatabaseObjectButton galleryButton;
    public GameObject divisionsParent;

    // panel stuff
    protected override void setToRepresent(DatabaseObject databaseObject)
    {
        if (databaseObject is Department) department = databaseObject as Department;
    }

    protected override void setAttributes()
    {
        // set up department label
        label.text = department.getLabel();

        // set up description
        description.text = department.getDescription();

        // set up gallery button
        if (department.getGallery() != null)
        {
            galleryButton.setup(this, department.getGallery());
        }

        // set up divisions
        if (department.getDivisions() != null)
        {
            List<Division> divisions = department.getDivisions();
            foreach (Division division in divisions)
            {
                DatabaseObjectButton divisionButton = Instantiate(databaseObjectButtonPrefab, transform.position, Quaternion.identity) as DatabaseObjectButton;
                divisionButton.setup(this, division);
                divisionButton.transform.SetParent(divisionsParent.transform, true);
            }
        }
    }
}

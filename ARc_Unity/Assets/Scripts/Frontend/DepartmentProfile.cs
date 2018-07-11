using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DepartmentProfile : Panel {

    private Department department;
    public Text label;
    public Text description;

    protected override void setToRepresent(DatabaseObject databaseObject)
    {
        if (databaseObject is Department) department = databaseObject as Department;
        else department = null;
    }

    protected override void setAttributes()
    {
        // set up department label
        label.text = department.getLabel();

        // set up description
        description.text = department.getDescription();

        // set up divisions
        List<Division> divisions = department.getDivisions();
        foreach (Division division in divisions)
        {
            DatabaseObjectButton divisionButton = Instantiate(databaseObjectButtonPrefab, transform.position, Quaternion.identity) as DatabaseObjectButton;
            divisionButton.setup(this, division);
            divisionButton.transform.SetParent(this.transform, true);
            databaseObjectButtons.Add(divisionButton);
        }
    }
}

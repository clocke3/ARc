using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepartmentProfile : Panel {

    Department department;

    protected override void setToRepresent(DatabaseObject databaseObject)
    {
        if (databaseObject is Department) department = databaseObject as Department;
        else department = null;
    }

    protected override void setAttributes()
    {
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DivisionBlock : Panel {

    // variables
    private Division division;
    public Text label;
    public DatabaseObjectButton departmentButton;
    public GameObject rolesParent;

    // panel stuff
    protected override void setToRepresent(DatabaseObject databaseObject)
    {
        if (databaseObject is Division) division = databaseObject as Division;
        else division = null;
    }

    protected override void setAttributes()
    {
        // set up department label
        label.text = division.getLabel();

        // set up department button
        if (division.getDepartment() != null)
        {
            departmentButton.setup(this, division.getDepartment());
        }
        // set up roles
        if (division.getRoles() != null)
        {
            List<Role> roles = division.getRoles();
            foreach (Role role in roles)
            {
                DatabaseObjectButton roleButton = Instantiate(databaseObjectButtonPrefab, transform.position, Quaternion.identity) as DatabaseObjectButton;
                roleButton.setup(this, role);
                roleButton.transform.SetParent(rolesParent.transform, true);
                databaseObjectButtons.Add(roleButton);
            }
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoleBlock : Panel {
    
    // variables
    private Role role;
    public Text label;
    public DatabaseObjectButton divisionButton;
    public GameObject employeesParent;

    // panel stuff
    protected override void setToRepresent(DatabaseObject databaseObject)
    {
        if (databaseObject is Role) role = databaseObject as Role;
    }

    protected override void setAttributes()
    {
        // set up department label
        label.text = role.getLabel();

        // set up division button
        if (role.getDivision() != null)
        {
            divisionButton.setup(this, role.getDivision());
        }
        // set up employees
        if (role.getEmployees() != null)
        {
            List<Employee> employees = role.getEmployees();
            foreach (Employee employee in employees)
            {
                DatabaseObjectButton employeeButton = Instantiate(databaseObjectButtonPrefab, transform.position, Quaternion.identity) as DatabaseObjectButton;
                employeeButton.setup(this, employee);
                employeeButton.transform.SetParent(employeesParent.transform, true);
            }
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : ItemManager {

    public void showProfile() {
        Employee employee = Employee.CreateInstance("Arnold", null, null, null, null);
        Employee employee2 = Employee.CreateInstance("David", null, null, null, null);
        Employee employee3 = Employee.CreateInstance("Apple", null, null, null, null);
        Employee employee4 = Employee.CreateInstance("Pizza", null, null, null, null);
        Employee employee5 = Employee.CreateInstance("Consumation", null, null, null, null);
        Employee employee6 = Employee.CreateInstance("Intimidation", null, null, null, null);
        Employee employee7 = Employee.CreateInstance("Fart", null, null, null, null);
        List<Employee> employees = new List<Employee>();
        employees.Add(employee);
        employees.Add(employee2);
        employees.Add(employee3);
        employees.Add(employee4);
        employees.Add(employee5);
        employees.Add(employee6);
        employees.Add(employee7);

        Role role = Role.CreateInstance("PM", null, employees);
        List<Role> roles = new List<Role>();
        roles.Add(role);


        Division division = Division.CreateInstance("Application Development", null, roles);
        List<Division> divisions = new List<Division>();
        divisions.Add(division);

        string descript = "The IT department makes stuff and does other things as well, we're pretty cool and you're cool if you like us, but if you don't like us we'll fricking cut your face";

        Department department = Department.CreateInstance("IT", "", null, descript, divisions);

        foreach (Division div in department.getDivisions())
        {
            div.setDepartment(department);

            foreach (Role roll in div.getRoles())
            {
                roll.setDivision(div);

                foreach (Employee emp in roll.getEmployees())
                {
                    emp.setRole(roll);
                }
            }
        }




        displayProfile(department);
    }

}

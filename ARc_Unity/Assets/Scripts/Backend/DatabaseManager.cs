using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.SceneManagement;

public class DatabaseManager : MonoBehaviour
{
    
    // variables
    private static DatabaseManager instance = null;       //database (FIX WHEN READY)
    private static List<Department> departments;
    //remove after
    public static List<Employee> employees;

    // Initialization

    //private void OnEnable()
    //{
    //    addMock();
    //}

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else Destroy(gameObject);
        //DontDestroyOnLoad(gameObject);
        departments = new List<Department>();
        employees = new List<Employee>();

        addMock();
    }

    void Start()
    {
        //string conn = "URI=file:" + Application.dataPath + "/test.db"; //Path to database.
        //IDbConnection dbconn;
        //dbconn = (IDbConnection)new SqliteConnection(conn);
        //dbconn.Open(); //Open connection to the database.
        //IDbCommand dbcmd = dbconn.CreateCommand();
        //string sqlQuery = "SELECT QR_ID,LAST_NAME,FIRST_NAME,POSITION,DIVISION," +
        //       "WORK_DURATION,HOBBIES " + "FROM EMPLOYEE";
        //dbcmd.CommandText = sqlQuery;
        //IDataReader reader = dbcmd.ExecuteReader();
        //while (reader.Read())
        //{
        //    string qrid = reader.GetString(0);
        //    string in_name = reader.GetString(1) + "," + reader.GetString(2);
        //    string pos = reader.GetString(3);
        //    string dep = reader.GetString(4);
        //    string dur = reader.GetString(5);
        //    string hob = reader.GetString(6);

        //    bool isNew = true;
        //    Department b = Department.CreateInstance(dep, qrid, null, null, null, null);
        //    foreach (Department find in departments)
        //    {
        //        if (b.isEqual(find))
        //        {
        //            isNew = false;
        //            break;
        //        }
        //    }
        //    if(isNew) departments.Add(b);

        //    isNew = true;
        //    Employee e = Employee.CreateInstance(in_name, qrid, null, null, null, hob);
        //    foreach (Employee find in employees)
        //    {
        //        if (e.isEqual(find))
        //        {
        //            isNew = false;
        //            break;
        //        }
        //    }
        //    if (isNew) employees.Add(e);

        //    //Debug.Log("qr =" + qrid + "name = " + in_name + "  position = " + pos +
        //    //          "hob=" + hob);
        //    //Debug.Log(e.getHobbies());
        //}
        //reader.Close();
        //reader = null;
        //dbcmd.Dispose();
        //dbcmd = null;
        //dbconn.Close();
        //dbconn = null;
    }

    //bool hasMocked = false;
    private void addMock() {
        //if (hasMocked) return;
        //hasMocked = true;

        // DEPARTMENT1
        //  MEDIAGALLERIES FOR EMPLOYEES
        List<Sprite> d1employee1photos = new List<Sprite>();
        d1employee1photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/VennardWright"));

        List<Sprite> d1employee2photos = new List<Sprite>();
        d1employee2photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/DennisPhillips"));

        List<Sprite> d1employee3photos = new List<Sprite>();
        d1employee3photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/MonicaCunanan"));

        MediaGallery d1employee1gallery = MediaGallery.CreateInstance(null, d1employee1photos);
        MediaGallery d1employee2gallery = MediaGallery.CreateInstance(null, d1employee2photos);
        MediaGallery d1employee3gallery = MediaGallery.CreateInstance(null, d1employee3photos);


        //  MEDIAGALLERY FOR DEPARTMENT
        List<Sprite> department1photos = new List<Sprite>();
        department1photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/InformationTechnology"));

        MediaGallery department1gallery = MediaGallery.CreateInstance(null, department1photos);


        //  EMPLOYEES
        string d1employee1hobbies = "Track and Field";
        string d1employee2hobbies = "Hunting, Fishing";
        string d1employee3hobbies = "Comic-Con, Gym, and Dogs";

        Sprite d1employee1profilepic = Resources.Load<Sprite>("Sprites/GallerySprites/VennardWright");
        Sprite d1employee2profilepic = Resources.Load<Sprite>("Sprites/GallerySprites/DennisPhillips");
        Sprite d1employee3profilepic = Resources.Load<Sprite>("Sprites/GallerySprites/MonicaCunanan");

        Sprite d1employee1location = Resources.Load<Sprite>("Sprites/LocationSprites/VennardWright");
        Sprite d1employee2location = Resources.Load<Sprite>("Sprites/LocationSprites/DennisPhillips");
        Sprite d1employee3location = Resources.Load<Sprite>("Sprites/LocationSprites/MonicaCunanan");

        Employee d1employee1 = Employee.CreateInstance("Vennard Wright", "d1employee1", d1employee1gallery, d1employee1location, null, d1employee1hobbies, "VennardWright", d1employee1profilepic);
        Employee d1employee2 = Employee.CreateInstance("Dennis Phillips", "d1employee2", d1employee2gallery, d1employee2location, null, d1employee2hobbies, "DennisPhillips", d1employee2profilepic);
        Employee d1employee3 = Employee.CreateInstance("Monica Cunanan", "d1employee3", d1employee3gallery, d1employee3location, null, d1employee3hobbies, "MonicaCunanan", d1employee3profilepic);

        employees.Add(d1employee1);
        employees.Add(d1employee2);
        employees.Add(d1employee3);

        d1employee1gallery.setProfiable(d1employee1);
        d1employee2gallery.setProfiable(d1employee2);
        d1employee3gallery.setProfiable(d1employee3);


        //  ROLES
        List<Employee> d1role1employeesList = new List<Employee>();
        d1role1employeesList.Add(d1employee1);

        List<Employee> d1role2employeesList = new List<Employee>();
        d1role2employeesList.Add(d1employee2);

        List<Employee> d1role3employeesList = new List<Employee>();
        d1role3employeesList.Add(d1employee3);

        Role d1role1 = Role.CreateInstance("Chief Information Officer", null, d1role1employeesList);
        Role d1role2 = Role.CreateInstance("Quality Assurance Manager", null, d1role2employeesList);
        Role d1role3 = Role.CreateInstance("Management Support Specialist", null, d1role3employeesList);

        d1employee1.setRole(d1role1);
        d1employee2.setRole(d1role2);
        d1employee3.setRole(d1role3);


        //  DIVISIONS
        List<Role> d1div1rolesList = new List<Role>();
        d1div1rolesList.Add(d1role1);
        d1div1rolesList.Add(d1role3);

        List<Role> d1div2rolesList = new List<Role>();
        d1div2rolesList.Add(d1role2);

        //List<Role> d1div3rolesList = new List<Role>();
        //d1div3rolesList.Add(d1role3);

        Division d1div1 = Division.CreateInstance("Office of the Chief Information Officer", null, d1div1rolesList);
        Division d1div2 = Division.CreateInstance("Quality Assurance", null, d1div2rolesList);
        //Division d1div3 = Division.CreateInstance("D1DIV3", null, d1div3rolesList);

        d1role1.setDivision(d1div1);
        d1role2.setDivision(d1div2);
        //d1role3.setDivision(d1div3);
        d1role3.setDivision(d1div1);


        //  DEPARTMENT
        List<Division> d1divList = new List<Division>();
        d1divList.Add(d1div1);
        d1divList.Add(d1div2);
        //d1divList.Add(d1div3);

        string d1desc = "The Information Technology(IT) Team is a strategic partner to WSSC's business units. We provide fully - integrated information technology solutions that will help business units to use technology more effectively and efficiently and have a positive effect on reducing the Commission's  overall operating costs.";

        Sprite d1Location = Resources.Load<Sprite>("Sprites/LocationSprites/4thFloor");

        Department d1 = Department.CreateInstance("Information Technology", "d1", department1gallery, d1Location, d1desc, d1divList);

        department1gallery.setProfiable(d1);

        foreach (Division division in d1divList)
        {
            division.setDepartment(d1);
        }

        departments.Add(d1);


        // DEPARTMENT2
        //  MEDIAGALLERIES FOR EMPLOYEES
        List<Sprite> d2employee1photos = new List<Sprite>();
        d2employee1photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/ChristinaGaskins"));

        List<Sprite> d2employee2photos = new List<Sprite>();
        d2employee2photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/JamesUhrich"));

        List<Sprite> d2employee3photos = new List<Sprite>();
        d2employee3photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/LeeMcDonough"));

        MediaGallery d2employee1gallery = MediaGallery.CreateInstance(null, d2employee1photos);
        MediaGallery d2employee2gallery = MediaGallery.CreateInstance(null, d2employee2photos);
        MediaGallery d2employee3gallery = MediaGallery.CreateInstance(null, d2employee3photos);


        //  MEDIAGALLERY FOR DEPARTMENT
        List<Sprite> department2photos = new List<Sprite>();
        department2photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/HumanResources"));

        MediaGallery department2gallery = MediaGallery.CreateInstance(null, department2photos);


        //  EMPLOYEES
        string d2employee1hobbies = "Reading inspirational quotes, Loves family";
        string d2employee2hobbies = "Biking and Watching football";
        string d2employee3hobbies = "Gardening and Biking";

        Sprite d2employee1profilepic = Resources.Load<Sprite>("Sprites/GallerySprites/ChristinaGaskins");
        Sprite d2employee2profilepic = Resources.Load<Sprite>("Sprites/GallerySprites/JamesUhrich");
        Sprite d2employee3profilepic = Resources.Load<Sprite>("Sprites/GallerySprites/LeeMcDonough");

        Sprite d2employee1location = Resources.Load<Sprite>("Sprites/LocationSprites/ChristinaGaskins");
        Sprite d2employee2location = Resources.Load<Sprite>("Sprites/LocationSprites/JamesUhrich");
        Sprite d2employee3location = Resources.Load<Sprite>("Sprites/LocationSprites/LeeMcDonough");

        Employee d2employee1 = Employee.CreateInstance("Christina Gaskins", "d2employee1", d2employee1gallery, d2employee1location, null, d2employee1hobbies, "ChristinaGaskins", d2employee1profilepic);
        Employee d2employee2 = Employee.CreateInstance("James Uhrich", "d2employee2", d2employee2gallery, d2employee2location, null, d2employee2hobbies, "JamesUhrich", d2employee2profilepic);
        Employee d2employee3 = Employee.CreateInstance("Lee McDonough", "d2employee3", d2employee3gallery, d2employee3location, null, d2employee3hobbies, "LeeMcDonough", d2employee3profilepic);

        employees.Add(d2employee1);
        employees.Add(d2employee2);
        employees.Add(d2employee3);

        d2employee1gallery.setProfiable(d2employee1);
        d2employee2gallery.setProfiable(d2employee2);
        d2employee3gallery.setProfiable(d2employee3);


        //  ROLES
        List<Employee> d2role1employeesList = new List<Employee>();
        d2role1employeesList.Add(d2employee1);

        List<Employee> d2role2employeesList = new List<Employee>();
        d2role2employeesList.Add(d2employee2);

        List<Employee> d2role3employeesList = new List<Employee>();
        d2role3employeesList.Add(d2employee3);

        Role d2role1 = Role.CreateInstance("Human Resource Coordinator", null, d2role1employeesList);
        Role d2role2 = Role.CreateInstance("Human Resource Specialist", null, d2role2employeesList);
        Role d2role3 = Role.CreateInstance("Benefits Specialist", null, d2role3employeesList);

        d2employee1.setRole(d2role1);
        d2employee2.setRole(d2role2);
        d2employee3.setRole(d2role3);


        //  DIVISIONS
        List<Role> d2div1rolesList = new List<Role>();
        d2div1rolesList.Add(d2role1);

        List<Role> d2div2rolesList = new List<Role>();
        d2div2rolesList.Add(d2role2);

        List<Role> d2div3rolesList = new List<Role>();
        d2div3rolesList.Add(d2role3);

        Division d2div1 = Division.CreateInstance("Talent Acquisition", null, d2div1rolesList);
        Division d2div2 = Division.CreateInstance("Compensation", null, d2div2rolesList);
        Division d2div3 = Division.CreateInstance("Benefits", null, d2div3rolesList);

        d2role1.setDivision(d2div1);
        d2role2.setDivision(d2div2);
        d2role3.setDivision(d2div3);


        //  DEPARTMENT
        List<Division> d2divList = new List<Division>();
        d2divList.Add(d2div1);
        d2divList.Add(d2div2);
        d2divList.Add(d2div3);

        string d2desc = "The Human Resource Office supports employee, team, and organizational success; and the Commission by providing quality employee systems in talent management, employee development, and total rewards.";

        Sprite d2Location = Resources.Load<Sprite>("Sprites/LocationSprites/6thFloor");

        Department d2 = Department.CreateInstance("Human Resources", "d2", department2gallery, d2Location, d2desc, d2divList);

        department2gallery.setProfiable(d2);

        foreach (Division division in d2divList)
        {
            division.setDepartment(d2);
        }

        departments.Add(d2);



    }

    //private void OnLevelWasLoaded(int level)
    //{
    //    Start();
    //    addMock();

    //}

    // getters
    public static DatabaseManager getInstance()
    {
        return instance;
    }

    public List<Profiable> search(string keyword)
    {
        // return a list of all departments and employees with a label featuring keyword
        List<Profiable> profiables = new List<Profiable>();

        if (departments != null)
        {
            foreach (Department department in departments)
            {
                //Debug.Log(department.getLabel());
                if (department.getLabel().ToLower().Contains(keyword.ToLower()))
                {
                    profiables.Add(department);
                }
            }
        }
        if (employees != null)
        {
            foreach (Employee employee in employees)
            {
                //Debug.Log(employee.getLabel());
                if (employee.getLabel().ToLower().Contains(keyword.ToLower()))
                {
                    profiables.Add(employee);
                }
            }
        }

        //foreach (Department department in departments)
        //{
        //    if (department.getLabel().Contains(keyword))
        //    {
        //        profiables.Add(department);
        //    }

        //    if (department.getDivisions() == null) continue;
        //    foreach (Division division in department.getDivisions())
        //    {
        //        if (division.getRoles() == null) continue;
        //        foreach (Role role in division.getRoles())
        //        {
        //            if (role.getEmployees() == null) continue;
        //            foreach (Employee employee in role.getEmployees())
        //            {
        //                if (employee.getLabel().Contains(keyword))
        //                {
        //                    profiables.Add(employee);
        //                }
        //            }
        //        }
        //    }
        //}

        return profiables;
    }

    public List<Profiable> search(string keyword, int typeID)
    {
        // return a list of all departments/employees (determined by typeID) with labels containing keyword
        List<Profiable> profiables = new List<Profiable>();

        if (typeID == DatabaseObject.DEPARTMENT)
        {
            if (departments != null)
            {
                foreach (Department department in departments)
                {
                    if (department.getLabel().ToLower().Contains(keyword.ToLower()))
                    {
                        profiables.Add(department);
                    }
                }
            }
        }
        else if (typeID == DatabaseObject.EMPLOYEE)
        {
            if (employees != null)
            {
                foreach (Employee employee in employees)
                {
                    if (employee.getLabel().ToLower().Contains(keyword.ToLower()))
                    {
                        profiables.Add(employee);
                    }
                }
            }
        }


        //if(typeID == DatabaseObject.DEPARTMENT) {
        //    foreach (Department department in departments)
        //    {
        //        if(department.getLabel().Contains(keyword)) {
        //            profiables.Add(department);
        //        }
        //    }

        //} else if(typeID == DatabaseObject.EMPLOYEE) {

        //    foreach (Department department in departments)
        //    {
        //        if (department.getDivisions() == null) continue;
        //        foreach (Division division in department.getDivisions())
        //        {
        //            if (division.getRoles() == null) continue;
        //            foreach (Role role in division.getRoles())
        //            {
        //                if (role.getEmployees() == null) continue;
        //                foreach (Employee employee in role.getEmployees())
        //                {
        //                    if (employee.getLabel().Contains(keyword))
        //                    {
        //                        profiables.Add(employee);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        return profiables;
    }

    // finders
    public Profiable getProfiable(string qrID)
    {
        // search through departments and return the Profiable with the given qrID, or null if the qrID never comes up

        if (departments != null)
        {
            foreach (Department department in departments)
            {
                if (department.equalQRID(qrID))
                {
                    return department;
                }
            }
        }
        if (employees != null)
        {
            foreach (Employee employee in employees)
            {
                if (employee.equalQRID(qrID))
                {
                    return employee;
                }
            }
        }

        return null;
    }

    public bool containsCode(string qrID)
    {
        // search through departments and say whether or not qrID comes up
        return getProfiable(qrID) != null;
    }
}
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
    private void addMock()
    {
        //if (hasMocked) return;
        //hasMocked = true;

        // INFORMATION TECHNOLOGY
        //  MEDIAGALLERIES FOR EMPLOYEES
        List<Sprite> d1employee1photos = new List<Sprite>();
        d1employee1photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/VennardWright"));

        List<Sprite> d1employee2photos = new List<Sprite>();
        d1employee2photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/DennisPhillips"));
        d1employee2photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/Fishing"));

        List<Sprite> d1employee3photos = new List<Sprite>();
        d1employee3photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/MonicaCunanan"));
        d1employee3photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/ComicCon"));
        d1employee3photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/Gym"));
        d1employee3photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/Dogs"));

        List<Sprite> d1employee4photos = new List<Sprite>();
        d1employee4photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/ScottWray"));

        List<Sprite> d1employee5photos = new List<Sprite>();
        d1employee5photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/CharlenaLove"));


        MediaGallery d1employee1gallery = MediaGallery.CreateInstance(null, d1employee1photos);
        MediaGallery d1employee2gallery = MediaGallery.CreateInstance(null, d1employee2photos);
        MediaGallery d1employee3gallery = MediaGallery.CreateInstance(null, d1employee3photos);
        MediaGallery d1employee4gallery = MediaGallery.CreateInstance(null, d1employee4photos);
        MediaGallery d1employee5gallery = MediaGallery.CreateInstance(null, d1employee5photos);


        //  MEDIAGALLERY FOR DEPARTMENT
        List<Sprite> department1photos = new List<Sprite>();
        department1photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/InformationTechnology"));
        department1photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/VennardWright"));
        department1photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/DennisPhillips"));
        department1photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/ScottWray"));
        department1photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/CharlenaLove"));
        department1photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/MonicaCunanan"));

        MediaGallery department1gallery = MediaGallery.CreateInstance(null, department1photos);


        //  EMPLOYEES
        string d1employee1hobbies = "Track and Field";
        string d1employee2hobbies = "Hunting, Fishing";
        string d1employee3hobbies = "Comic-Con, Gym, and Dogs";
        string d1employee4hobbies = "Triathlons, Surfing, and Coaching Youth Athletics";
        string d1employee5hobbies = "Designing Tumblers, and Game of Thrones";

        Sprite d1employee1profilepic = Resources.Load<Sprite>("Sprites/GallerySprites/VennardWright");
        Sprite d1employee2profilepic = Resources.Load<Sprite>("Sprites/GallerySprites/DennisPhillips");
        Sprite d1employee3profilepic = Resources.Load<Sprite>("Sprites/GallerySprites/MonicaCunanan");
        Sprite d1employee4profilepic = Resources.Load<Sprite>("Sprites/GallerySprites/ScottWray");
        Sprite d1employee5profilepic = Resources.Load<Sprite>("Sprites/GallerySprites/CharlenaLove");

        Sprite d1employee1location = Resources.Load<Sprite>("Sprites/LocationSprites/VennardWright");
        Sprite d1employee2location = Resources.Load<Sprite>("Sprites/LocationSprites/DennisPhillips");
        Sprite d1employee3location = Resources.Load<Sprite>("Sprites/LocationSprites/MonicaCunanan");
        Sprite d1employee4location = Resources.Load<Sprite>("Sprites/LocationSprites/ScottWray");
        Sprite d1employee5location = Resources.Load<Sprite>("Sprites/LocationSprites/CharlenaLove");

        Employee d1employee1 = Employee.CreateInstance("Vennard Wright", "d1employee1", d1employee1gallery, d1employee1location, null, d1employee1hobbies, "Vennard.Wright@wsscwater.com", d1employee1profilepic);
        Employee d1employee2 = Employee.CreateInstance("Dennis Phillips", "d1employee2", d1employee2gallery, d1employee2location, null, d1employee2hobbies, "Dennis.Phillips@wsscwater.com", d1employee2profilepic);
        Employee d1employee3 = Employee.CreateInstance("Monica Cunanan", "d1employee3", d1employee3gallery, d1employee3location, null, d1employee3hobbies, "Monica.Cunanan@wsscwater.com", d1employee3profilepic);
        Employee d1employee4 = Employee.CreateInstance("Scott Wray", "d1employee4", d1employee4gallery, d1employee4location, null, d1employee4hobbies, "Scott.Wray@wsscwater.com", d1employee4profilepic);
        Employee d1employee5 = Employee.CreateInstance("Charlena Love", "d1employee5", d1employee5gallery, d1employee5location, null, d1employee5hobbies, "Charlena.Love@wsscwater.com", d1employee5profilepic);

        employees.Add(d1employee1);
        employees.Add(d1employee2);
        employees.Add(d1employee3);
        employees.Add(d1employee4);
        employees.Add(d1employee5);

        d1employee1gallery.setProfiable(d1employee1);
        d1employee2gallery.setProfiable(d1employee2);
        d1employee3gallery.setProfiable(d1employee3);
        d1employee4gallery.setProfiable(d1employee4);


        //  ROLES
        List<Employee> d1role1employeesList = new List<Employee>();
        d1role1employeesList.Add(d1employee1);

        List<Employee> d1role2employeesList = new List<Employee>();
        d1role2employeesList.Add(d1employee2);

        List<Employee> d1role3employeesList = new List<Employee>();
        d1role3employeesList.Add(d1employee3);

        List<Employee> d1role4employeesList = new List<Employee>();
        d1role4employeesList.Add(d1employee4);

        List<Employee> d1role5employeesList = new List<Employee>();
        d1role5employeesList.Add(d1employee5);

        Role d1role1 = Role.CreateInstance("Chief Information Officer", null, d1role1employeesList);
        Role d1role2 = Role.CreateInstance("Quality Assurance Manager", null, d1role2employeesList);
        Role d1role3 = Role.CreateInstance("Management Support Specialist", null, d1role3employeesList);
        Role d1role4 = Role.CreateInstance("Creativity Analyst", null, d1role4employeesList);
        Role d1role5 = Role.CreateInstance("Administrative Assistant III", null, d1role5employeesList);

        d1employee1.setRole(d1role1);
        d1employee2.setRole(d1role2);
        d1employee3.setRole(d1role3);
        d1employee4.setRole(d1role4);
        d1employee5.setRole(d1role5);


        //  DIVISIONS
        List<Role> d1div1rolesList = new List<Role>();
        d1div1rolesList.Add(d1role1);
        d1div1rolesList.Add(d1role3);
        d1div1rolesList.Add(d1role4);
        d1div1rolesList.Add(d1role5);

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
        d1role4.setDivision(d1div1);
        d1role5.setDivision(d1div1);


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


        // HUMAN RESOURCES
        //  MEDIAGALLERIES FOR EMPLOYEES
        List<Sprite> d2employee1photos = new List<Sprite>();
        d2employee1photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/ChristinaGaskins"));

        List<Sprite> d2employee2photos = new List<Sprite>();
        d2employee2photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/JamesUhrich"));

        List<Sprite> d2employee3photos = new List<Sprite>();
        d2employee3photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/LeeMcDonough"));

        List<Sprite> d2employee4photos = new List<Sprite>();
        d2employee4photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/PamelaPalmer"));

        List<Sprite> d2employee5photos = new List<Sprite>();
        d2employee5photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/NanaOlibris"));

        List<Sprite> d2employee6photos = new List<Sprite>();
        d2employee5photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/HumanResources"));

        MediaGallery d2employee1gallery = MediaGallery.CreateInstance(null, d2employee1photos);
        MediaGallery d2employee2gallery = MediaGallery.CreateInstance(null, d2employee2photos);
        MediaGallery d2employee3gallery = MediaGallery.CreateInstance(null, d2employee3photos);
        MediaGallery d2employee4gallery = MediaGallery.CreateInstance(null, d2employee4photos);
        MediaGallery d2employee5gallery = MediaGallery.CreateInstance(null, d2employee5photos);
        MediaGallery d2employee6gallery = MediaGallery.CreateInstance(null, d2employee6photos);

        //  MEDIAGALLERY FOR DEPARTMENT
        List<Sprite> department2photos = new List<Sprite>();
        department2photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/HumanResources"));

        MediaGallery department2gallery = MediaGallery.CreateInstance(null, department2photos);


        //  EMPLOYEES
        string d2employee1hobbies = "Reading inspirational quotes, Loves family";
        string d2employee2hobbies = "Biking and Watching football";
        string d2employee3hobbies = "Gardening and Biking";
        string d2employee4hobbies = "Reading";
        string d2employee5hobbies = "Soccer";
        string d2employee6hobbies = "Cooking, Reading, Christmas, and Mystery Movies";

        Sprite d2employee1profilepic = Resources.Load<Sprite>("Sprites/GallerySprites/ChristinaGaskins");
        Sprite d2employee2profilepic = Resources.Load<Sprite>("Sprites/GallerySprites/JamesUhrich");
        Sprite d2employee3profilepic = Resources.Load<Sprite>("Sprites/GallerySprites/LeeMcDonough");
        Sprite d2employee4profilepic = Resources.Load<Sprite>("Sprites/GallerySprites/PamelaPalmer");
        Sprite d2employee5profilepic = Resources.Load<Sprite>("Sprites/GallerySprites/NanaOlibris");
        Sprite d2employee6profilepic = Resources.Load<Sprite>("Sprites/GallerySprites/ChristinaRobinson");

        Sprite d2employee1location = Resources.Load<Sprite>("Sprites/LocationSprites/ChristinaGaskins");
        Sprite d2employee2location = Resources.Load<Sprite>("Sprites/LocationSprites/JamesUhrich");
        Sprite d2employee3location = Resources.Load<Sprite>("Sprites/LocationSprites/LeeMcDonough");
        Sprite d2employee4location = Resources.Load<Sprite>("Sprites/LocationSprites/PamelaPalmer");
        Sprite d2employee5location = Resources.Load<Sprite>("Sprites/LocationSprites/NanaOlibris");
        Sprite d2employee6location = Resources.Load<Sprite>("Sprites/LocationSprites/ChristinaRobinson");

        Employee d2employee1 = Employee.CreateInstance("Christina Gaskins", "d2employee1", d2employee1gallery, d2employee1location, null, d2employee1hobbies, "Christina.Gaskins@wsscwater.com", d2employee1profilepic);
        Employee d2employee2 = Employee.CreateInstance("James Uhrich", "d2employee2", d2employee2gallery, d2employee2location, null, d2employee2hobbies, "James.Uhrich@wsscwater.com", d2employee2profilepic);
        Employee d2employee3 = Employee.CreateInstance("Lee McDonough", "d2employee3", d2employee3gallery, d2employee3location, null, d2employee3hobbies, "Lee.McDonough@wsscwater.com", d2employee3profilepic);
        Employee d2employee4 = Employee.CreateInstance("Pamela Palmer", "d2employee4", d2employee4gallery, d2employee4location, null, d2employee4hobbies, "Pamela.Palmer@wsscwater.com", d2employee4profilepic);
        Employee d2employee5 = Employee.CreateInstance("Nana Olibris", "d2employee5", d2employee5gallery, d2employee5location, null, d2employee5hobbies, "Nana.Olibris@wsscwater.com", d2employee5profilepic);
        Employee d2employee6 = Employee.CreateInstance("Christina Robinson", "d2employee6", d2employee6gallery, d2employee6location, null, d2employee6hobbies, "Christina.Robinson@wsscwater.com", d2employee6profilepic);

        employees.Add(d2employee1);
        employees.Add(d2employee2);
        employees.Add(d2employee3);
        employees.Add(d2employee4);
        employees.Add(d2employee5);
        employees.Add(d2employee6);

        d2employee1gallery.setProfiable(d2employee1);
        d2employee2gallery.setProfiable(d2employee2);
        d2employee3gallery.setProfiable(d2employee3);
        d2employee4gallery.setProfiable(d2employee4);
        d2employee5gallery.setProfiable(d2employee5);
        d2employee6gallery.setProfiable(d2employee6);


        //  ROLES
        List<Employee> d2role1employeesList = new List<Employee>();
        d2role1employeesList.Add(d2employee1);

        List<Employee> d2role2employeesList = new List<Employee>();
        d2role2employeesList.Add(d2employee2);
        d2role2employeesList.Add(d2employee4);

        List<Employee> d2role3employeesList = new List<Employee>();
        d2role3employeesList.Add(d2employee3);

        List<Employee> d2role4employeesList = new List<Employee>();
        d2role4employeesList.Add(d2employee5);

        List<Employee> d2role5employeesList = new List<Employee>();
        d2role5employeesList.Add(d2employee6);

        Role d2role1 = Role.CreateInstance("Human Resource Coordinator", null, d2role1employeesList);
        Role d2role2 = Role.CreateInstance("Human Resource Specialist", null, d2role2employeesList);
        Role d2role3 = Role.CreateInstance("Benefits Specialist", null, d2role3employeesList);
        Role d2role4 = Role.CreateInstance("Human Resource Specialist", null, d2role4employeesList);
        Role d2role5 = Role.CreateInstance("Division Manager", null, d2role5employeesList);


        d2employee1.setRole(d2role1);
        d2employee2.setRole(d2role2);
        d2employee3.setRole(d2role3);
        d2employee4.setRole(d2role2);
        d2employee5.setRole(d2role4);
        d2employee6.setRole(d2role5);



        //  DIVISIONS
        List<Role> d2div1rolesList = new List<Role>();
        d2div1rolesList.Add(d2role1);
        d2div1rolesList.Add(d2role5);

        List<Role> d2div2rolesList = new List<Role>();
        d2div2rolesList.Add(d2role2);

        List<Role> d2div3rolesList = new List<Role>();
        d2div3rolesList.Add(d2role3);

        List<Role> d2div4rolesList = new List<Role>();
        d2div4rolesList.Add(d2role4);

        Division d2div1 = Division.CreateInstance("Talent Acquisition", null, d2div1rolesList);
        Division d2div2 = Division.CreateInstance("Compensation", null, d2div2rolesList);
        Division d2div3 = Division.CreateInstance("Benefits", null, d2div3rolesList);
        Division d2div4 = Division.CreateInstance("Talent & Development", null, d2div4rolesList);

        d2role1.setDivision(d2div1);
        d2role2.setDivision(d2div2);
        d2role3.setDivision(d2div3);
        d2role4.setDivision(d2div4);


        //  DEPARTMENT
        List<Division> d2divList = new List<Division>();
        d2divList.Add(d2div1);
        d2divList.Add(d2div2);
        d2divList.Add(d2div3);
        d2divList.Add(d2div4);

        string d2desc = "The Human Resource Office supports employee, team, and organizational success; and the Commission by providing quality employee systems in talent management, employee development, and total rewards.";

        Sprite d2Location = Resources.Load<Sprite>("Sprites/LocationSprites/6thFloor");

        Department d2 = Department.CreateInstance("Human Resources", "d2", department2gallery, d2Location, d2desc, d2divList);

        department2gallery.setProfiable(d2);

        foreach (Division division in d2divList)
        {
            division.setDepartment(d2);
        }

        departments.Add(d2);





        //Commissioners Office
        List<Sprite> d3employee1photos = new List<Sprite>();
        d3employee1photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/wssc"));

        MediaGallery d3employee1gallery = MediaGallery.CreateInstance(null, d3employee1photos);

        string d3employee1hobbies = "Reading, Theater, Live Music, Pilates, and Socializing";

        List<Sprite> department3photos = new List<Sprite>();
        department3photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/wssc"));

        MediaGallery department3gallery = MediaGallery.CreateInstance(null, department3photos);

        Sprite d3employee1profilepic = Resources.Load<Sprite>("Sprites/GallerySprites/T.EloiseFoster");

        Sprite d3employee1location = Resources.Load<Sprite>("Sprites/LocationSprites/wssc");

        Employee d3employee1 = Employee.CreateInstance("T.Eloise Foster", "d3employee1", d3employee1gallery, d3employee1location,
                                                       null, d3employee1hobbies, "T.EloiseFoster", d3employee1profilepic);
        employees.Add(d3employee1);

        d3employee1gallery.setProfiable(d3employee1);

        List<Employee> d3role1employeesList = new List<Employee>();
        d3role1employeesList.Add(d3employee1);

        Role d3role1 = Role.CreateInstance("Commissioner", null, d3role1employeesList);

        d3employee1.setRole(d3role1);

        List<Role> d3div1rolesList = new List<Role>();
        d3div1rolesList.Add(d3role1);

        Division d3div1 = Division.CreateInstance("Corporate Secretary's Office", null, d3div1rolesList);

        d3role1.setDivision(d3div1);

        List<Division> d3divList = new List<Division>();
        d3divList.Add(d3div1);

        string d3desc = "Commissioners' Office";
    Sprite d3Location = Resources.Load<Sprite>("Sprites/LocationSprites/12thFloor");

        Department d3 = Department.CreateInstance("Commissioners' Office", "d3", department3gallery, d3Location, d3desc, d3divList);

        department3gallery.setProfiable(d3);

        foreach (Division division in d3divList)
        {
            division.setDepartment(d3);
        }

        departments.Add(d3);

        //General Services
        List<Sprite> d4employee1photos = new List<Sprite>();
        d4employee1photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/wssc"));

        MediaGallery d4employee1gallery = MediaGallery.CreateInstance(null, d4employee1photos);

        string d4employee1hobbies = "Reading, Travel, and Good Eats";

        List<Sprite> department4photos = new List<Sprite>();
        department4photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/wssc"));

        MediaGallery department4gallery = MediaGallery.CreateInstance(null, department4photos);

        Sprite d4employee1profilepic = Resources.Load<Sprite>("Sprites/GallerySprites/RobertHsu");

        Sprite d4employee1location = Resources.Load<Sprite>("Sprites/LocationSprites/wssc");

        Employee d4employee1 = Employee.CreateInstance("Robert Hsu", "d4employee1", d4employee1gallery, 
                                                       d4employee1location,
                                                       null, d4employee1hobbies, "RobertHsu", d4employee1profilepic);
        employees.Add(d4employee1);

        d4employee1gallery.setProfiable(d4employee1);

        List<Employee> d4role1employeesList = new List<Employee>();
        d4role1employeesList.Add(d4employee1);

        Role d4role1 = Role.CreateInstance("Business Development Manager", null, d4role1employeesList);

        d4employee1.setRole(d4role1);

        List<Role> d4div1rolesList = new List<Role>();
        d4div1rolesList.Add(d4role1);

        Division d4div1 = Division.CreateInstance("General Services", null, d4div1rolesList);

        d4role1.setDivision(d4div1);

        List<Division> d4divList = new List<Division>();
        d4divList.Add(d4div1);

        string d4desc = "General Services";
        Sprite d4Location = Resources.Load<Sprite>("Sprites/LocationSprites/12thFloor");

        Department d4 = Department.CreateInstance("General Services", "d4", 
                                                  department4gallery, d4Location, d4desc, d4divList);

        department4gallery.setProfiable(d4);

        foreach (Division division in d4divList)
        {
            division.setDepartment(d4);
        }

        departments.Add(d4);

        //Finance Office
        List<Sprite> d5employee1photos = new List<Sprite>();
        d5employee1photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/wssc"));

        MediaGallery d5employee1gallery = MediaGallery.CreateInstance(null, d5employee1photos);

        string d5employee1hobbies = "Gardening, Exercise, Reading, Football, and Basketball";

        List<Sprite> department5photos = new List<Sprite>();
        department5photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/wssc"));

        MediaGallery department5gallery = MediaGallery.CreateInstance(null, department5photos);

        Sprite d5employee1profilepic = Resources.Load<Sprite>("Sprites/GallerySprites/JoeBeach");

        Sprite d5employee1location = Resources.Load<Sprite>("Sprites/LocationSprites/wssc");

        Employee d5employee1 = Employee.CreateInstance("Joe Beach", "d5employee1", d5employee1gallery,
                                                       d5employee1location,
                                                       null, d5employee1hobbies, "JoeBeach", d5employee1profilepic);
        employees.Add(d5employee1);

        d5employee1gallery.setProfiable(d5employee1);

        List<Employee> d5role1employeesList = new List<Employee>();
        d5role1employeesList.Add(d5employee1);

        Role d5role1 = Role.CreateInstance("Chief Financial Officer", null, d5role1employeesList);

        d5employee1.setRole(d5role1);

        List<Role> d5div1rolesList = new List<Role>();
        d5div1rolesList.Add(d5role1);

        Division d5div1 = Division.CreateInstance("Department Head", null, d5div1rolesList);

        d5role1.setDivision(d5div1);

        List<Division> d5divList = new List<Division>();
        d5divList.Add(d5div1);

        string d5desc = "Department Head";
        Sprite d5Location = Resources.Load<Sprite>("Sprites/LocationSprites/12thFloor");

        Department d5 = Department.CreateInstance("Finance Office", "d5",
                                                  department5gallery, d5Location, d5desc, d5divList);

        department5gallery.setProfiable(d5);

        foreach (Division division in d5divList)
        {
            division.setDepartment(d5);
        }

        departments.Add(d5);

        //General Manager's Office
        List<Sprite> d6employee1photos = new List<Sprite>();
        List<Sprite> d6employee2photos = new List<Sprite>();

        d6employee1photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/wssc"));
        d6employee2photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/wssc"));

        MediaGallery d6employee1gallery = MediaGallery.CreateInstance(null, d6employee1photos);
        MediaGallery d6employee2gallery = MediaGallery.CreateInstance(null, d6employee2photos);

        string d6employee1hobbies = "Redskins, Capitals, Nats, and Concerts";
        string d6employee2hobbies = "Reading, Dancing, Tea Parties, Playing Cards, and Scrapbooking";

        List<Sprite> department6photos = new List<Sprite>();
        department6photos.Add(Resources.Load<Sprite>("Sprites/GallerySprites/wssc"));

        MediaGallery department6gallery = MediaGallery.CreateInstance(null, department6photos);

        Sprite d6employee1profilepic = Resources.Load<Sprite>("Sprites/GallerySprites/JoeMantua");
        Sprite d6employee2profilepic = Resources.Load<Sprite>("Sprites/GallerySprites/CarlaReid");

        Sprite d6employee1location = Resources.Load<Sprite>("Sprites/LocationSprites/wssc");
        Sprite d6employee2location = Resources.Load<Sprite>("Sprites/LocationSprites/wssc");

        Employee d6employee1 = Employee.CreateInstance("Joe Mantua", "d6employee1", d6employee1gallery,
                                                       d6employee1location,
                                                       null, d6employee1hobbies, "JoeMantua", d6employee1profilepic);
        Employee d6employee2 = Employee.CreateInstance("Carla Reid", "d6employee2", d6employee2gallery,
                                                       d6employee2location,
                                                      null, d6employee2hobbies, "CarlaReid", d6employee2profilepic);
        
        employees.Add(d6employee1);
        employees.Add(d6employee2);

        d6employee1gallery.setProfiable(d6employee1);
        d6employee2gallery.setProfiable(d6employee2);

        List<Employee> d6role1employeesList = new List<Employee>();
        List<Employee> d6role2employeesList = new List<Employee>();

        Role d6role1 = Role.CreateInstance("Deputy GM for Operations", null, d6role1employeesList);
        Role d6role2 = Role.CreateInstance("General Manager/CEO", null, d6role2employeesList);

        d6employee1.setRole(d6role1);
        d6employee2.setRole(d6role2);

        List<Role> d6div1rolesList = new List<Role>();
        d6div1rolesList.Add(d6role1);
        d6div1rolesList.Add(d6role2);

        Division d6div1 = Division.CreateInstance("Department Head", null, d6div1rolesList);

        d6role1.setDivision(d6div1);
        d6role2.setDivision(d6div1);

        List<Division> d6divList = new List<Division>();
        d6divList.Add(d6div1);

        string d6desc = "Department Head";
        Sprite d6Location = Resources.Load<Sprite>("Sprites/LocationSprites/12thFloor");

        Department d6 = Department.CreateInstance("General Manager's Office", "d6",
                                                  department6gallery, d6Location, d6desc, d6divList);

        department6gallery.setProfiable(d6);

        foreach (Division division in d6divList)
        {
            division.setDepartment(d6);
        }

        departments.Add(d6);


        // DEFAULT DEPARTMENT
        //  MEDIAGALLERIES FOR EMPLOYEES
        List<Sprite> dfemployee1photos = null;

        MediaGallery dfemployee1gallery = MediaGallery.CreateInstance(null, dfemployee1photos);

        //  MEDIAGALLERY FOR DEPARTMENT
        List<Sprite> departmentfphotos = null;

        MediaGallery departmentfgallery = MediaGallery.CreateInstance(null, departmentfphotos);


        //  EMPLOYEE
        string dfemployee1hobbies = null;

        Sprite dfemployee1profilepic = null;

        Sprite dfemployee1location = null;

        Employee dfemployee1 = Employee.CreateInstance("Default Employee", "dfemployee1", dfemployee1gallery, dfemployee1location, null, dfemployee1hobbies, "default@wsscwater.com", dfemployee1profilepic);

        employees.Add(dfemployee1);

        dfemployee1gallery.setProfiable(dfemployee1);


        //  ROLE
        List<Employee> dfrole1employeesList = new List<Employee>();
        dfrole1employeesList.Add(dfemployee1);

        Role dfrole1 = Role.CreateInstance("Default Role", null, dfrole1employeesList);

        dfemployee1.setRole(dfrole1);


        //  DIVISION
        List<Role> dfdiv1rolesList = new List<Role>();
        dfdiv1rolesList.Add(dfrole1);

        Division dfdiv1 = Division.CreateInstance("Default Division", null, dfdiv1rolesList);

        dfrole1.setDivision(dfdiv1);


        //  DEPARTMENT
        List<Division> dfdivList = new List<Division>();
        dfdivList.Add(dfdiv1);

        string dfdesc = "Default Description";

        Sprite dfLocation = Resources.Load<Sprite>("Sprites/LocationSprites/Default");

        Department df = Department.CreateInstance("Default Department", "df", departmentfgallery, dfLocation, dfdesc, dfdivList);

        departmentfgallery.setProfiable(df);

        foreach (Division division in dfdivList)
        {
            division.setDepartment(df);
        }

        departments.Add(df);

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
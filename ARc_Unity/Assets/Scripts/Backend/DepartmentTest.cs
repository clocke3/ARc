using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Department;
using Division;

public class DepartmentTest : MonoBehaviour
{

    public class DepartmentTest(){
        private Department model;

        public void Setup() throw Exception{
            model = new Department();
            model.name = "Information Technology";
            model.description = "This department is in charge of all computers in the building.";
            model.divisions = new List<Division>("GIS", "Application Development", "Database");
            model.typeID = 2;
            model.qrID = "CAO2973";
            model.galleryID = 7;
        }

        public void Start(){


            
        }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//not working
public class DepartmentTest : MonoBehaviour
{
        private Department model;

    private void Start() {
        Setup();
    }

    //set up
    public void Setup() throw Exception{
            model = new Department();
            model.name = "Information Technology";
            model.description = "This department is in charge of all computers in the building.";
            model.divisions = new List<Division>("GIS", "Application Development", "Database");
            model.typeID = 2;
            model.qrID = "CAO2973";
            model.galleryID = 7;
        }

        //tests
        public void test_getName(){
            Assert.areEqual(model.getName(), "Information Technology");
        }

        public void test_getDescription(){
            Assert.areEqual(model.getDescription(), "This department is in charge of all computers in the building.");
        }

        public void test_getDivisions(){
            Assert.areEqual(model.getDivisions(), new List<Division>("GIS", "Application Development", "Database"));
        }

        public void test_getTypeID(){
            Assert.areEqual(model.getTypeID(), 2);
        }

        public void test_getQRID(){
            Assert.areEqual(model.getQRID(), "CAO2973");
        }

        public void test_getGalleryID(){
            Assert.areEqual(model.getGalleryID(), 7);
        }
}

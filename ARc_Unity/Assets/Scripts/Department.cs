using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Department : Profiable
{
    private string description;
    private List<string> divisions;
    private string name;
    private int galleryID;

    private Department (name, description, divisions, galleryID){
        this.name = name;
        this.description = description;
        this.divisions = divisons;
        this.galleryID = galleryID;
    }

    public string getDescription(){
        return description;
    }
    public List<string> getDivisions(){
        return divisions;
    }
    private string getName(){
        return name;
    }
    private int getGalleryID(){
        return galleryID;
    }
}

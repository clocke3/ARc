using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Department : Profiable
{
    private string name, description;
    private List<string> divisions;
    private int galleryID;

    public Department(){
        name = "";
        description = "";
        divisions = null;
        galleryID = 0;
    }

    public Department(string name, string description, List<string> divisions, int galleryID)
    {
        this.name = name;
        this.description = description;
        this.divisions = divisions;
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

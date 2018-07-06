using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Department : Profiable
{
    public string description;
    public List<string> divisions; 
    private string name;
    private int galleryID;

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

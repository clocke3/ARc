using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DatabaseObject : MonoBehaviour {

    // variables
    string label;

    // constructor
    protected DatabaseObject(string label) {
        this.label = label;
    }

    // getters
    public string getLabel() {
        return label;
    }

}

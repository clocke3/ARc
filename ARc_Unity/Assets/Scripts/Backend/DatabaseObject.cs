using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DatabaseObject : MonoBehaviour {

    string label;

    protected DatabaseObject(string label) {
        this.label = label;
    }

    public string getLabel() {
        return label;
    }

}

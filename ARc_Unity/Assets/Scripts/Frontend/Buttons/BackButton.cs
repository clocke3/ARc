using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour {
    
    // variables
    public GameObject thisObject;

    // closer
    public void back()
    {
        Destroy(this.thisObject);
    }
}

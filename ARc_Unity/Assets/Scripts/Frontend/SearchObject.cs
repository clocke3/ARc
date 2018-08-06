using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchObject : MonoBehaviour {

    private bool hasStarted = true;

	// Update is called once per frame
	void Update () {
        if(hasStarted) {
            hasStarted = false;
            this.gameObject.SetActive(false);
        }
	}
}

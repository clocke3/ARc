using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour {
    
    // variables
    public Panel panel;

    // setup
    public void setup(Panel panel) {
        this.panel = panel;
    }

    // closer
    public void exit()
    {
        this.panel.exit();
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitMenu : MonoBehaviour {

    // variables
    public MainMenu mainMenu;

    // open main menu
    public void openMainMenu() {
        mainMenu.gameObject.SetActive(true);
        this.gameObject.SetActive(false);
    }

    // quit application
    public void quitApp() {
        Debug.Log("QUIT");
        Application.Quit();
    }
}

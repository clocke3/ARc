using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMainMenuButton : MonoBehaviour {

    private string mainMenuSceneName = "MainMenu";

	// load main menu scene
    public void loadMainMenu() {
        SceneManager.LoadScene(mainMenuSceneName);
    }

}

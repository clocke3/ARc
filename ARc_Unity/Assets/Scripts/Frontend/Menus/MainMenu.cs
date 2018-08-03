using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    
    // variables
    public QuitMenu quitMenu;

    private string scanSceneName = "betterScan";
    private string searchSceneName = "SearchScene";
    private string tutorialSceneName = "Tutorials";
    private string camScreen = "backgroundCam";

	// init. menus
	void Start () {
        this.gameObject.SetActive(true);
        quitMenu.gameObject.SetActive(false);
	}
	
    // open quit menu
    public void openQuitMenu() {
        quitMenu.gameObject.SetActive(true);
        this.gameObject.SetActive(false);
    }

    // load scan scene
    public void openScan() {
        SceneManager.LoadScene(scanSceneName);
    }

    // load search scene
    public void openSearch()
    {
        SceneManager.LoadScene(searchSceneName);
    }

    // load tutorials scene
    public void openTutorials()
    {
        SceneManager.LoadScene(tutorialSceneName);
    }
	
}

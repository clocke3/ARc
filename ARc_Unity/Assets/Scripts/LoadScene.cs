using System.Collections;
using UnityEngine.SceneManagement; 
using UnityEngine;

public class LoadScene : MonoBehaviour
{
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(5);
        FadeManager.instance.FadeOutToScene(1);
    }


}



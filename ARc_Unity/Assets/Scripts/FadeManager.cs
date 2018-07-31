using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class FadeManager : MonoBehaviour {

    public static FadeManager instance;

    public Image fadeImage;

    public Color startColor;
    public Color endColor;
    public float duration;

    private bool isFading; 


    private void Awake()
    {
        instance = this; 
    }
    public void Start()
    {
        FadeIn(); 
    }

    public void FadeIn()
    {
        StartCoroutine(BeginFade()); 
    }

    public void FadeOutToScene(int sceneIndex)
    {
        StartCoroutine(BeginFade(sceneIndex));
    }

    public void FadeOutToScene(string sceneName)
    {
        StartCoroutine(BeginFade(sceneName));
    }


    private IEnumerator BeginFade()
    {
        isFading = true;

        float timer = 0f; 

        while(timer <= duration)
        {
            fadeImage.color = Color.Lerp(startColor, endColor, timer / duration);
            timer += Time.deltaTime;
            yield return null; 
        }

        isFading = false; 

    }

    private IEnumerator BeginFade(int sceneIndex)
    {
        isFading = true;

        float timer = 0f;

        while (timer <= duration)
        {
            fadeImage.color = Color.Lerp(endColor, startColor, timer / duration);
            timer += Time.deltaTime;
            yield return null;
        }

        isFading = false;

        SceneManager.LoadScene(sceneIndex);
    }


    private IEnumerator BeginFade(string sceneName)
    {
        isFading = true;

        float timer = 0f;

        while (timer <= duration)
        {
            fadeImage.color = Color.Lerp(endColor, startColor, timer / duration);
            timer += Time.deltaTime;
            yield return null;
        }

        isFading = false;

        SceneManager.LoadScene(sceneName);
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transicion : MonoBehaviour
{

    public bool StartFadein = false;
    public CanvasGroup canvas;
    public string sceneName;

    void Start()
    {
        if (StartFadein)
        {
            StartCoroutine(FadeIn());
        }

    }

    public void StartFadeOut()
    {
        StartCoroutine(FadeOut());

    }



    public void LoadNextScene()
    {

        SceneManager.LoadScene(sceneName);

    }

    public void Salir()
    {
        Application.Quit();
    }

    public IEnumerator FadeOut()
    {
        canvas.alpha = 0;

        while (canvas.alpha < 1)
        {
            canvas.alpha += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

        LoadNextScene();
    }

    public IEnumerator FadeIn()
    {
        canvas.alpha = 1;
        while (canvas.alpha > 0)
        {
            canvas.alpha -= Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
    }
}

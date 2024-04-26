using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroUI : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("opening");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void GoInfo()
    {
        SceneManager.LoadScene("info");
    }

    public void BackIntro()
    {
        SceneManager.LoadScene("intro");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitScript : MonoBehaviour
{
    public void doExitGame() {
        Application.Quit();
    }

    public void doExitScene()
    {
        SceneManager.LoadScene("menu");
    }

    public void doEnterSettings()
    {
        SceneManager.LoadScene("settings");
    }

    public void doStratGame()
    {
        SceneManager.LoadScene("level1");
    }

    public void LoadNewScene()
    {
        SceneManager.LoadScene("menu");
    }
}

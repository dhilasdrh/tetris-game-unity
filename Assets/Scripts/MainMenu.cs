using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject settingswindow;
    
    public void StartPlay(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void GameSettings()
    {
        settingswindow.SetActive(true);
    }

    public void CloseSettingsWindow()
    {
        settingswindow.SetActive(false);
    }
}

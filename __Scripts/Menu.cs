using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [Header("Set in Inspector")]
    public string level;
    public string credits;
    public string options;
    public string mainmenu;
    public string endscreen;

    public void PlayGame()
    {
        SceneManager.LoadScene(level);
    }

    public void ShowMainMenu()
    {
        SceneManager.LoadScene(mainmenu);
    }
    
    public void ShowOptions()
    {
        SceneManager.LoadScene(options);
    }
    public void ShowCredits()
    {
        SceneManager.LoadScene(credits);
    }

    public void ShowEndScreen()
    {
        SceneManager.LoadScene(endscreen);
    }

    public void ExitGame()
    {
        #if UNITY_STANDALONE
            Application.Quit();
        #endif

        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
	
}

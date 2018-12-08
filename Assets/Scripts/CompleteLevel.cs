using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteLevel : MonoBehaviour
{
    public string nextLevel = "Level02";
    public int levelToUnlock = 2;

    public string menuSceneName = "MainMenu";

    public void Menu()
    {
        SceneManager.LoadScene(menuSceneName);
    }

    public void Continue()
    {
        Debug.Log("Level Won!");
        PlayerPrefs.SetInt("levelReached", 2);
        SceneManager.LoadScene(nextLevel);
    }
}

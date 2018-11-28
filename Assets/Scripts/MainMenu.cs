using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    public string LevelToLoad = "MainLevel";

    public void Play()
    {
        Debug.Log("Play!");
        SceneManager.LoadScene(LevelToLoad);
    }

    public void Quit()
    {
        Debug.Log("Exiting...");
        Application.Quit();
    }
}

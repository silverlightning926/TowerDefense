using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static bool GameIsOver;

    public GameObject gameOverUI;
    public GameObject playerUI;

    public string nextLevel = "Level02";
    public int levelToUnlock = 2;

    void Start()
    {
        GameIsOver = false;
    }

    // Update is called once per frame
    void Update() {

        if (GameIsOver)
        {
            return;
        }

        if (PlayerStats.Lives <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        GameIsOver = true;
        playerUI.SetActive(false);
        gameOverUI.SetActive(true);
    }

    public void WinLevel()
    {
        Debug.Log("Level Won!");
        PlayerPrefs.SetInt("levelReached", 2);
        SceneManager.LoadScene(nextLevel);
    }
}

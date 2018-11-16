using UnityEngine;

public class GameManager : MonoBehaviour {

    public static bool GameIsOver;

    public GameObject gameOverUI;
    public GameObject playerUI;

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
}

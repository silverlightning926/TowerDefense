﻿using UnityEngine.SceneManagement; 
using UnityEngine.UI;
using UnityEngine;

public class GameOver : MonoBehaviour {

    public Text roundsText;

    void OnEnable()
    {
        roundsText.text = PlayerStats.Rounds.ToString();
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        Debug.Log("Go to menu!");
    }
}

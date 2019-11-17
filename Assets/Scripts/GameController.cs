using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    // public float winScore;    // Alleen nodig bij een ander win-model (haal XX punten = win)
    public Text scoreText;
    public Text restartText;
    public Text gameOverText;
    public int scoreValue;
    public int junkValue;

    private bool gameOver;
    private bool restart;
    private int score;

    void Start()
    {
        gameOver = false;
        restart = false;
        restartText.text = "";
        gameOverText.text = "";
        UpdateScore();

    }

    void Update()
    {
        if (restart)  // Only if status restart = true game resets on R button press.
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Application.LoadLevel(Application.loadedLevel);
                Time.timeScale = 1;
            }
        }
    }

    public void AddScore(int newScoreValue)
    {
        if (newScoreValue == 1)
            score += scoreValue;
            UpdateScore();
        if (newScoreValue == 0)
            score += junkValue;
            UpdateScore();
     /*   if (score == winScore)
        {
            GameOver();
        }
        */
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverText.text = "Het spel is afgelopen! Je eindscore is: " + score;
        restartText.text = "Je kunt nog een keer spelen door op 'R' te drukken.";
        restart = true;
        gameOver = true;
    }
}

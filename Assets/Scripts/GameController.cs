using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
   // public GameObject hazard;
   // public Vector3 spawnValues;
   // public int hazardCount;
    public float winScore;
   // public float startWait;
   // public float waveWait;

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
    //    score = 0;
        UpdateScore();
     //   StartCoroutine(SpawnWaves());
    }

    void Update()
    {
        if (restart)
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
        if (score == winScore)
        {
            GameOver();
        }

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

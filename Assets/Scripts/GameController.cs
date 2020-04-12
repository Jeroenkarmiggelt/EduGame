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
    public static int score;

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
            if (Input.GetKeyDown(KeyCode.Space))
            {
                score = 0;
                UnityEngine.SceneManagement.SceneManager.LoadScene(0);
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
        restartText.text = "Druk op spatie om naar het menu te gaan.";
        restart = true;
        gameOver = true;
        CallSaveData();
    }

    public void CallSaveData()
    {
        StartCoroutine(SavePlayerData());

    }

    IEnumerator SavePlayerData()
    {
        if (DBManager.score < score)
        {
            DBManager.score = score;
            WWWForm form = new WWWForm();
            form.AddField("name", DBManager.username);
            form.AddField("score", DBManager.score);

            WWW www = new WWW("http://localhost/sqlconnect/savedata.php", form);
            yield return www;
            if (www.text == "0")
            {
                Debug.Log("Game Saved.");
            }
            else
            {
                Debug.Log("Save failed. Error #" + www.text);
            }
        }

    }

}





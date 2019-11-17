using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{

    public int gameTime;
    public Text countdownText;
    private GameController gameController;

    // Use this for initialization
    void Start()
    {
        StartCoroutine("LoseTime");

    }

    // Update is called once per frame
    void Update()
    {
        countdownText.text = ("Time Left = " + gameTime);

        if (gameTime <= 0)
        {
            StopCoroutine("LoseTime");
            countdownText.text = "Times Up!";
            gameController.GameOver();
            //Application.Quit();
        }
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            gameTime--;
        }
    }
}
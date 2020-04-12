using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{

    public int gameTime;
    public Text countdownText;
    private GameController gameController;
    private Quaternion initial;

    // Use this for initialization
    void Start()
    {
        StartCoroutine("LoseTime");

            
        // Check if GameController exists

        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }

    

    }

    // Update is called once per frame
    private void Awake()
    {


    }
    public void Update()
    {
        countdownText.text = ("Tijd over: " + gameTime);



    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            gameTime--;
            if (gameTime <= 0)
            {
                StopCoroutine("LoseTime");
                countdownText.text = "Tijd is op!";
                gameController.GameOver();
                //Application.Quit();
            }
        }
    }
}
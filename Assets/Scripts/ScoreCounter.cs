using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{

  //  public Text countText;
  //  public Text winText;

    private Rigidbody rb;
  //  private int count;

    private GameController gameController;
    public int scoreValue;
    public int junkValue;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    //    count = 0;
    //    SetCountText();
    //    winText.text = "";

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

    void FixedUpdate()
    {


    }
    void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            gameController.AddScore(scoreValue);
            //          count = count + 1;
            //          SetCountText();
        }
        if (other.gameObject.CompareTag("Junk"))
        {
            other.gameObject.SetActive(false);
            gameController.AddScore(junkValue);
            //          count = count + 1;
  //          SetCountText();
        }

    }
  //  void SetCountText()
  //  {
   //     countText.text = "Count: " + count.ToString();
    //    if (count >= 4)
    //    {
    //        winText.text = "You win";
    //    }
   // }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{

    private Rigidbody rb;
  

    private GameController gameController;
    private Quaternion initial;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
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
        if (Input.GetKeyDown(KeyCode.R))
            transform.rotation = initial;
    }
    void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            gameController.AddScore(1);
           // initial = other.transform.rotation;

        }
        if (other.gameObject.CompareTag("Junk"))
        {
            other.gameObject.SetActive(false);
            gameController.AddScore(0);
        }


        if (other.gameObject.CompareTag("Finish"))
        {
            other.gameObject.SetActive(false);
            gameController.GameOver();
        }

    }


}

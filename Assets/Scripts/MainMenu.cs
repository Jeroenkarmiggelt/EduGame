using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;




public class MainMenu : MonoBehaviour {

    public Button registerButton;
    public Button loginButton;
    public Button playButton;
    public Button logoutButton;
    public GameObject scoreboard;

    public Text playerDisplay;


    public void Start()
    {
        if (DBManager.LoggedIn)
        {
            playerDisplay.text = "Player: " + DBManager.username + "       Highscore: " + DBManager.score;
            scoreboard.gameObject.SetActive(true);
        }

        if (!DBManager.LoggedIn)
        {
        //    playerDisplay.text = "Player: " + DBManager.username + "       Current highscore: " + DBManager.score;
            scoreboard.gameObject.SetActive(false);
        }
        registerButton.interactable = !DBManager.LoggedIn;
        loginButton.interactable = !DBManager.LoggedIn;
        playButton.interactable = DBManager.LoggedIn;
        logoutButton.interactable = DBManager.LoggedIn;


    }

    public void GoToRegister()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToLogin()
    {
        SceneManager.LoadScene(2);
    }

    public void GoToGame()
    {
        SceneManager.LoadScene(3);
    }

    public void LogOutNow()
    {
        DBManager.LogOut();
        SceneManager.LoadScene(0);
    }
}

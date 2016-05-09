using UnityEngine;
using System.Collections;
using Assets.Scripts;
using UnityEngine.UI;

public class EventManage : MonoBehaviour
{
    public static GameState currentGameState = GameState.menuScreen;
    public Text message;

    // Use this for initialization

    void Awake()
    {
        currentGameState = GameState.menuScreen;                            //on game awakwe set the state to the menu screen
        Time.timeScale = 1.0f;
    }

    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
        if (currentGameState == GameState.gameEnd)
        {
            if (PlayerPrefs.GetFloat("HighScore") <= TheTimer.passedTime)
            {
                message.text = "New High Score";
                float score = TheTimer.passedTime;
                PlayerPrefs.SetFloat("HighScore", score);
            }
            Time.timeScale = 0.0f;
        }
    }

    public void HighScoreClick()
    {
        message.text = PlayerPrefs.GetFloat("HighScore").ToString();
    }
}

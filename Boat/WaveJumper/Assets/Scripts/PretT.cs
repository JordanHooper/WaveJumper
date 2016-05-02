using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Assets.Scripts;

public class PretT : MonoBehaviour
{
    public Text theText;
    string gameStuff;
    float remainTime = 6f;


    void Start()
    {
        theText = GetComponent<Text>();
        gameStuff = ("Get ready");
    }


    public void ButtonClick()
    {
        //Debug.Log("CLICKED MENU");
        EventManage.currentGameState = GameState.preGame;                  //on the button click, set the game state change
    }

    void Update()
    {
        if (EventManage.currentGameState == GameState.preGame)
        {
            theText.text = gameStuff;
            if (remainTime <= 4f)                                       //once there's 4 seconds left change to displaying a timer
            {
                theText.text = remainTime.ToString("f1");           //output time - with no decimals
            }
            if (remainTime <= 0f)                                       //once the timer is finished 
            {
                EventManage.currentGameState = GameState.running;           //set game state to running
                theText.text = "";
            }
            remainTime -= Time.deltaTime;
            // Debug.Log(remainTime);
        }
    }
}

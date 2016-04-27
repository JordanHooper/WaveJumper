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


    void Update()
    {
        if (EventManage.currentGameState == GameState.preGame)
        {
            theText.text = gameStuff;
            if (remainTime <= 4f)                                       //once there's 4 seconds left change to displaying a timer
            {
                theText.text = remainTime.ToString("f0");           //output time - with no decimals
            }
            if (remainTime <= 0f)                                       //once the timer is finished 
            {
                EventManage.currentGameState = GameState.running;           //set game state to running
            }
            remainTime -= Time.deltaTime;
        }
    }
}

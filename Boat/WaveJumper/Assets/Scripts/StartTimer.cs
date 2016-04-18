using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Assets.Scripts;

public class StartTimer : MonoBehaviour
{
    public float remainTime = 6f;
    public Text displayText;
    string gameStuff;
    bool GO = false;

    // Use this for initialization
    void Start()
    {
        gameStuff = ("Get ready");                                     //initialise a string
    }

    void ()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (EventManage.currentGameState == GameState.preGame)      //wait until ready
        {
            displayText.text = gameStuff;
            if (remainTime <= 4f)                                       //once there's 4 seconds left change to displaying a timer
            {
                displayText.text = remainTime.ToString("f0");           //output time - with no decimals
            }
            remainTime -= Time.deltaTime;                              //decrement timer
            if (remainTime <= 0f)                                       //once the timer is finished 
            {
                //set CurrentGameState.running;
            }
        }
    }
}

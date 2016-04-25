using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Assets.Scripts;

public class StartTimer : MonoBehaviour
{
    public float remainTime = 6f;
    Text displayText;
    string gameStuff;
    bool GO = false;
    Canvas menu;

    // Use this for initialization
    void Start()
    {
        displayText = GetComponent<Text>();
        menu = GetComponentInParent<Canvas>();
        if (displayText == null)
        {
            Debug.Log("no text found");
        }
        if (menu == null)
        {
            Debug.Log("no menu found");
        }
        gameStuff = ("Get ready");                                     //initialise a string
    }

    // Update is called once per frame

    public void ButtonClick()
    {
        Debug.Log("CLICKED MENU");
        EventManage.currentGameState = GameState.preGame;                  //on the button click, set the game state change
        //menu. = false;
    }

    void OnPointerDown()
    {
        Debug.Log("CLICKED MENU");
        EventManage.currentGameState = GameState.preGame;                  //on the button click, set the game state change
        //menu. = false;
    }

    void Update() //ButtonPressedEvent
    {
        
        if (EventManage.currentGameState == GameState.preGame)              //wait until ready
        {
            displayText.text = gameStuff;
            remainTime -= Time.deltaTime;                              //decrement timer
            if (remainTime <= 4f)                                       //once there's 4 seconds left change to displaying a timer
            {
                displayText.text = remainTime.ToString("f0");           //output time - with no decimals
            }
            if (remainTime <= 0f)                                       //once the timer is finished 
            {
                EventManage.currentGameState = GameState.running;           //set game state to running
            }
        }   
    }

    /*
    void OnGUI()
    {
        if (GUI.Button(new Rect(350, 270, 160, 30), "Single Player"))
        {
            enabled = false;
            EventManage.currentGameState = GameState.preGame;
        }
    }   */
}

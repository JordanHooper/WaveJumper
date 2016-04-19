using UnityEngine;
using System.Collections;
using Assets.Scripts;
using UnityEngine.UI;

public class EventManage : MonoBehaviour
{
    public static GameState currentGameState = GameState.menuScreen;
    
    // Use this for initialization

    void Awake()
    {
        currentGameState = GameState.menuScreen;
    }

    void Update()
    {
        if (currentGameState == GameState.running)
        {
            Time.timeScale = 1.0f;
        }
        else Time.timeScale = 0f;

      //  Button.ButtonClickedEvent;
        {
            if (currentGameState == GameState.menuScreen)
            {
                currentGameState = GameState.preGame;
            }
        }

    }
}

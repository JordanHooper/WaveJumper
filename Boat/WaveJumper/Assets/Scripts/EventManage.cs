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
        currentGameState = GameState.menuScreen;                            //on game awakwe set the state to the menu screen
        Time.timeScale = 1.0f;
    }

    void Update()
    {
        if (Input.GetKey("o"))
        {
            currentGameState = GameState.running;
            Debug.Log(currentGameState);
        }
    }
}

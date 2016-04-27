using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Assets.Scripts;

public class StartTimer : MonoBehaviour
{
    bool GO = false;
    Canvas menu;

    // Use this for initialization
    void Start()
    {
        menu = GetComponentInParent<Canvas>();
        if (menu == null)
        {
            Debug.Log("no menu found");
        }
    }

    // Update is called once per frame

    public void ButtonClick()
    {
        Debug.Log("CLICKED MENU");
        EventManage.currentGameState = GameState.preGame;                  //on the button click, set the game state change
        //menu. = false;
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

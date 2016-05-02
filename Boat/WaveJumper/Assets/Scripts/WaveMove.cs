using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class WaveMove : MonoBehaviour
{
    float i = 0, x = 0;                                                    //initiliase variables
    void Update()
    {
        i = (Mathf.Sin(x / 35)) / 4f;                        //function to allow the variable to decrease and increase depending on the time
        this.transform.Translate(i, 0, 0);               // move the sea according to the variable
        //Debug.Log(i);
        x++;
    }

    void OnCollisionEnter2D(Collision2D col)
    {      
        if (col.gameObject.tag == "Top")
        {
            EventManage.currentGameState = GameState.gameEnd;
        }
        
    }
}
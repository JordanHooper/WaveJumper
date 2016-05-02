using UnityEngine;
using System.Collections;
using Assets.Scripts;


public class BoatHealth : MonoBehaviour
{
    public SpriteRenderer currentHealth;
    public Sprite[] health = new Sprite[6];

    void Update()
    {
        if (BoatControl.damage >= 6)
        {
            EventManage.currentGameState = GameState.gameEnd;
        }
    }

    void LateUpdate()
    {
        if (EventManage.currentGameState == GameState.running)
            currentHealth.sprite = health[BoatControl.damage];
    }
}

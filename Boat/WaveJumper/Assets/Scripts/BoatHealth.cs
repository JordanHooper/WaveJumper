﻿using UnityEngine;
using System.Collections;
using Assets.Scripts;


public class BoatHealth : MonoBehaviour
{
    public SpriteRenderer currentHealth;
    public Sprite[] health = new Sprite[6];
    BoatControl boate;
    

    void Start()
    {
        boate = GetComponentInParent<BoatControl>();
    }

    void Update()
    {
        if (boate.damage >= 6)
        {
            EventManage.currentGameState = GameState.gameEnd;
        }
    }

    void LateUpdate()
    {
        if (EventManage.currentGameState == GameState.running)
        {
            currentHealth.sprite = health[boate.damage];
        }
    }
}

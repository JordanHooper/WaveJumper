using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Assets.Scripts;

public class TheTimer : MonoBehaviour
{
    public Text timeText;
    private float passedTime;
    void Update()
    {
        if (EventManage.currentGameState == GameState.running)
        {
            passedTime += Time.deltaTime;
            timeText.text = passedTime.ToString("f2");
        }
    }
}

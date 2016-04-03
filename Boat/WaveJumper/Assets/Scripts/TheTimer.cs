using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TheTimer : MonoBehaviour
{
    public Text timeText;
    private float passedTime;
    void Update()
    {
        passedTime += Time.deltaTime;
        timeText.text = passedTime.ToString("f2");
    }
}

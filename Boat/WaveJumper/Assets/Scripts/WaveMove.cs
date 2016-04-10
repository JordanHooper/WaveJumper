using UnityEngine;
using System.Collections;

public class WaveMove : MonoBehaviour
{
    float i = 0;                                                    //initiliase variables
    void Update()
    {
        i = Mathf.PingPong(Time.time/6, 0.3f) - 0.15f;              //function to allow the variable to decrease and increase depending on the time
        transform.Translate(i, 0, 0);                               // move the sea according to the variable
    }
}

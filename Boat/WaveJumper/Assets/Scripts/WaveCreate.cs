using UnityEngine;
using System.Collections;

public class WaveCreate : MonoBehaviour
{
    float nextTime = 2.5f;
    Random random = new Random();
    void FixedUpdate()
    {
        nextTime -= Time.deltaTime;
        
        if(nextTime <= 0.0f)
        {
            Instantiate(GameObject.FindGameObjectWithTag("Wave"));
            //random function to regenerate
        }
    }
}

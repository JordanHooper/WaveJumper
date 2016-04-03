using UnityEngine;
using System.Collections;



public class Wave : MonoBehaviour
{
    float waveSpeed = -0.08f;
    void FixedUpdate()
    {
        this.transform.Translate(waveSpeed, 0, 0);                  //move the wave by the speed variable
    }
}

using UnityEngine;
using System.Collections;

public class WaveCreate : MonoBehaviour
{
    float nextTime = 2.5f;
    Random random = new Random();
    public Rigidbody2D wavePrefab;

    void Awake()
    {

    }

    void FixedUpdate()
    {
        nextTime -= Time.deltaTime;
        
        if(nextTime <= 0.0f)
        {
            Rigidbody2D waveInstance;
            waveInstance = Instantiate(wavePrefab) as Rigidbody2D;
            //random function to regenerate
            nextTime = 4f;
        }
    }
}

using UnityEngine;
using System.Collections;

public class WaveCreate : MonoBehaviour
{

    public Rigidbody2D wavePrefab;
    public float ranMin, ranMax;
    float nextTime;
    Vector3 spawnPos;
    Quaternion spawnRot;
    Rigidbody2D waveInstance;
    public int noSpawned = 0;

    void Start()
    {
        spawnPos = this.transform.position;                                                      //set the spawn position
        spawnRot = this.transform.rotation;                                                      //set the spawn rotation
        waveInstance = Instantiate(wavePrefab, spawnPos, spawnRot) as Rigidbody2D;               //need to find a way to spawn it without speed
        nextTime = Random.Range(ranMin, ranMax);

    }

    void FixedUpdate()
    {
        nextTime -= Time.deltaTime;                                                              //decrement time counter

        if (nextTime <= 0.0f)                                                                  //once the time to the next spawn is reached
        {
            noSpawned++;
            waveInstance = Instantiate(wavePrefab, spawnPos, spawnRot) as Rigidbody2D;        //duplicate the wave
            nextTime = Random.Range(ranMin, ranMax);                                         //random function to regenerate the timer
        }
    }
}

using UnityEngine;
using System.Collections;



public class Wave : MonoBehaviour
{

    public float ranMin, ranMax;                            //set values in unity to control the speed of the waves
    public float waveSpeed;                             //set the speed to be a random value betwee the previously set values
    WaveCreate isChild;
  //  RigidbodyConstraints2D thing;
    

    void Awake()
    {
        isChild = GetComponentInParent<WaveCreate>();                 //if get component on parent then override the wavespeed
        //thing = GetComponent<RigidbodyConstraints2D>();
    }

    void Start()
    {
        if (isChild.noSpawned <= 1)
        {
            ranMax = 0;
            ranMin = 0;
        }
        else
        {
            ranMin = -0.4f;
            ranMax = -1.1f;
        }
        waveSpeed = Random.Range(ranMin, ranMax);
        float ran = Random.Range(0.5f, 2.5f);
        Vector3 vec = new Vector3(ran, ran, 0);
        this.transform.localScale = vec;                    //set the size of the wave to be a random size between the values
    }

    void FixedUpdate()
    {
        this.transform.Translate(waveSpeed, 0, 0);                  //move the wave by the speed variable
        waveSpeed = Random.Range(ranMin, ranMax);
        Debug.Log(waveSpeed);
    }
}

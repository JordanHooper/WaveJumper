using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class Wave : MonoBehaviour
{

    public float ranMin, ranMax;                            //set values in unity to control the speed of the waves
    public float waveSpeed;                             //set the speed to be a random value betwee the previously set values
    WaveCreate isChild;
    public ParticleSystem splash;
    bool goodCol=false;

    void Start()
    {
        isChild = GetComponentInParent<WaveCreate>();                 //if get component on parent then override the wavespeed
        if (isChild == null)
        {
            Debug.Log("DIDN'T FIND PARENT WAVE IDIOT");
        }
        waveSpeed = Random.Range(ranMin, ranMax);
        float ran = Random.Range(0.5f, 2.5f);
        Vector3 vec = new Vector3(ran, ran, 0);
        this.transform.localScale = vec;                    //set the size of the wave to be a random size between the values
    }

    void FixedUpdate()
    {
        if (EventManage.currentGameState == GameState.running)
        {
            this.transform.Translate(waveSpeed, 0, 0);                  //move the wave by the speed variable
            waveSpeed = Random.Range(ranMin, ranMax);
            //Debug.Log(waveSpeed);
            CheckOutOfArea();
        }
    }

    void CheckOutOfArea()
    {
        if (this.transform.position.x < -80f || this.transform.position.y < -15)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "front" && goodCol == false)
        {
            goodCol = true;
            HitPlayer();
        }
        if (col.gameObject.tag == "Bot" && goodCol == false)
        {
            BoatControl.damage++;
            HitPlayer();
        }
    }

    void HitPlayer()
    {
        waveSpeed = 0f;
        Destroy(this.gameObject, 0.5f);                                  //destroy wave
        splash.Play();
    }

}

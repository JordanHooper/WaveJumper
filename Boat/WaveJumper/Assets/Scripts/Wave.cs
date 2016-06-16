using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class Wave : MonoBehaviour
{

    public float ranMin, ranMax;                            //set values in unity to control the speed of the waves
    public float waveSpeed;                             //set the speed to be a random value betwee the previously set values
    WaveCreate isChild;
    public ParticleSystem splash;
    bool moveable = false;
    int waveDam = 1;
    BoatControl boatControl;

    void Start()
    {
        if (WaveCreate.noSpawned <= 1)
        {
            moveable = false;
        }
        else
        {
            moveable = true;
        }
       /* isChild = GetComponentInParent<WaveCreate>();                 //if get component on parent then override the wavespeed
        if (isChild == null)
        {
            Debug.Log("DIDN'T FIND PARENT WAVE IDIOT");
        } */
        waveSpeed = Random.Range(ranMin, ranMax);
        float ran = Random.Range(0.5f, 2.5f);
        Vector3 vec = new Vector3(ran, ran, 0);
        this.transform.localScale = vec;                    //set the size of the wave to be a random size between the values
    }

    void FixedUpdate()
    {
        if (EventManage.currentGameState == GameState.running && moveable == true)
        {
            waveSpeed = Random.Range(ranMin, ranMax);
            //Debug.Log(waveSpeed);
            this.transform.Translate(waveSpeed, 0, 0);                      //move the wave by the speed variable
            CheckOutOfArea();
        }
    }

    void CheckOutOfArea()
    {
        if (this.transform.position.x < -120f || this.transform.position.y < -15)
        {
            Destroy(this.gameObject);
            Debug.Log("Out of area");
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
       // Debug.Log(col.gameObject.tag);
        /* if ((col.gameObject.tag == "Bot") && (goodCol == false))
         {
             Debug.Log("Collision with bot");
             goodCol = true;
             HitPlayer();
         } */
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Hit player");
            GameObject boat = GameObject.Find("Boat");
            boatControl = boat.GetComponent<BoatControl>();
            boatControl.damage += waveDam;
            waveDam = 0;
            Debug.Log(boatControl.damage);
            HitPlayer();
        }
    }

    void HitPlayer()
    {
        waveSpeed = 0f;
        Destroy(this.gameObject, 0.5f);                                  //destroy wave
        splash.Play();
    }

    /*  void OnDestroy()
      {
          WaveCreate.SpawnWave();
      } */
}

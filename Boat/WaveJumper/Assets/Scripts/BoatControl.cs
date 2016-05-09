using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class BoatControl : MonoBehaviour
{
    public int damage = 0;
    float speed;
    bool checkSea = true;
    public ParticleSystem splash;


    /*  public int Damage
      {
          get
          {
              return damage;
          }
          set
          {
              damage = value;
          }
      } */
    void Awake()
    {
        Camera mainCamera = Camera.main;
    }

    void FixedUpdate()
    {
        if (this.transform.position.y <= -1.8f)
        {
            EventManage.currentGameState = GameState.gameEnd;
            Debug.Log("Boat too low");
        }
        //Debug.Log("Boat works fine");
        Vector2 movement = new Vector2(speed, 0);                           // declare movement vector
        if (EventManage.currentGameState == GameState.running)
        {
            if (Input.GetKey("d"))                                              // on d press
            {
                this.transform.Rotate(0, 0, -(Time.deltaTime * 3) - 2);         //rotate depending on how long the button is pressed
            }
            if (Input.GetKey("a"))
            {
                this.transform.Rotate(0, 0, (Time.deltaTime * 3) + 2);          // on a press as above
            }

            if (Input.GetKey("w") && checkSea == true && speed < 0.2)                          // if they press w and they're in contact with sea              
            {
                speed += Time.deltaTime / 2;                                    // allow them to move
            }
            if (Input.GetKey("s") && checkSea == true && speed > -0.2)                          // if they want to reverse on button s press                
            {
                speed -= Time.deltaTime;                                        //allow them to decelerate depending on how long they press
            }
        }
        //Debug.Log(speed);
        this.transform.Translate(movement);
        if (checkSea == true)
        {
            splash.Play();
        }
        else splash.Pause();
        //turn on splash using checksea

    }

    void OnCollision2DEnter(Collision2D col)
    {
        if (col.gameObject.tag == "Side")
        {
            checkSea = false;
        }
    }


    void OnCollision2DExit(Collision2D col)
    {
        Debug.Log("contact");
        if (col.gameObject.tag == "actSea")                                 //check to see if the boat is grounded 
        {
            checkSea = false;                                               //set false when they're not in contact
        }
        else
        {
            checkSea = true;
        }
    }
}

using UnityEngine;
using System.Collections;

public class BoatControl : MonoBehaviour
{
    public int damage = 0;
    float speed;
    bool checkSea;

    void FixedUpdate()
    {
        Vector2 movement = new Vector2(speed, 0);                           // declare movement vector

        if (Input.GetKey("d"))                                              // on d press
        {
            this.transform.Rotate(0, 0, -(Time.deltaTime * 3) - 2);         //rotate depending on how long the button is pressed
        }
        if (Input.GetKey("a"))
        {
            this.transform.Rotate(0, 0, (Time.deltaTime * 3) + 2);          // on a press as above
        }

        if (Input.GetKey("w") && checkSea == true)                          // if they press w and they're in contact with sea              
        {
            speed += Time.deltaTime / 2;                                    // allow them to move
        }
        if (Input.GetKey("s") && checkSea == true)                          // if they want to reverse on button s press                
        {
            speed = -Time.deltaTime;                                        //allow them to decelerate depending on how long they press
        }
        this.transform.Translate(movement);
    }

    void OnCollisionEnter2D(Collision2D col)                                //if they collide with a wave
    {
        if (col.gameObject.tag == "Wave")
        {
            Destroy(col.gameObject, 0.7f);                                  //destroy wave
            damage++;                                                       // take damage
        }
    }

    void OnCollisionExit(Collision col)
    {
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

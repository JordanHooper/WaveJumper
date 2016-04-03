using UnityEngine;
using System.Collections;

public class BoatHealth : MonoBehaviour
{
    public SpriteRenderer currentHealth;
    public Sprite[] health = new Sprite[6];
    BoatControl boate;

    void Awake()
    {
        boate = GetComponentInParent<BoatControl>();
        if (boate == null)
        {
            Debug.Log("couldn't find script");
        }
    }

    void LateUpdate()
    {
        currentHealth.sprite = health[boate.damage];
    }
}

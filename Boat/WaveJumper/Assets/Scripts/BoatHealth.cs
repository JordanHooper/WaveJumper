using UnityEngine;
using System.Collections;

public class BoatHealth : MonoBehaviour
{
    public SpriteRenderer currentHealth;
    public Sprite[] health = new Sprite[6];
    public int damage = 0, oldDamage = 0;

    void Update()
    {
        oldDamage = damage;

        if (Input.GetKeyDown("r"))
        {
            damage++;
            //	
        }
        // damage = GetComponentInParent<int>();
        if (damage > oldDamage)
        { currentHealth.sprite = WaveHit(); }

    }

    private Sprite WaveHit()
    {
        return health[damage];

        /* if (damage == 1)
        { return health1; }
        else if (damage == 2)
        { return health2; }
        else if (damage == 3)
        { return health3; }
        else if (damage == 4)
        { return health4; }
        else return health5; */
    }
}

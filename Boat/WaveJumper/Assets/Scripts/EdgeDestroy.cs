using UnityEngine;
using System.Collections;

public class EdgeDestroy : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Wave")
        {
            Destroy(col.gameObject);
        }
    }
}

using UnityEngine;
using System.Collections;

public class SetRota : MonoBehaviour
{
    Quaternion rot;

    void Awake()
    {
        rot = this.transform.rotation;
    }
    
    void LateUpdate()
    {
        this.transform.rotation = rot;
    }
}

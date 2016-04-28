using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Assets.Scripts;

public class StartTimer : MonoBehaviour
{
    bool GO = false;
    Canvas menu;

    // Use this for initialization
    void Start()
    {
        menu = GetComponentInParent<Canvas>();
        if (menu == null)
        {
            Debug.Log("no menu found");
        }
    }

}

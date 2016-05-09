using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Assets.Scripts;

public class MenuControl : MonoBehaviour
{
    public Button but1, but2, but3;

    public void Selected()
    {
        but1.gameObject.SetActive(false);
        but2.gameObject.SetActive(false);
        but3.gameObject.SetActive(false);
    }
}

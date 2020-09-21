using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ClickScript : MonoBehaviour
{
    public GameObject gb;
    public void callme()
    {
       gb.SetActive(false);
    }
}

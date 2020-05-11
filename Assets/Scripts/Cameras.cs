using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameras : MonoBehaviour
{

    public GameObject P1;
    public GameObject P2;

     public Camera main;
     public Camera C1;
     public Camera C2;

    private bool a = true;

    public KeyCode change;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        a = true;
        if (Input.GetKey(change))
        {
            a = false;
            main.enabled = true;
            C2.enabled = false;
            C1.enabled = false;

        }

        if (Countdown.turn && a)
        {
            C1.enabled = true;
            C2.enabled = false;
            main.enabled = false;
        }
        else if(!Countdown.turn && a) { 
            C2.enabled = true;
            C1.enabled = false;
            main.enabled = false;
        }

        

    }
}

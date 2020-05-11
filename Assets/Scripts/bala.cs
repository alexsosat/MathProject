using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    public KeyCode disparar;
    public GameObject bala1;
    public static bool disparo=false;
    public Transform bazuca;
    public GameObject player;

    private void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKey(disparar)&&!disparo) {
           //Explicar esta linea
            GameObject balaClone = (GameObject) Instantiate(bala1,bazuca.position,bazuca.rotation);
            balaClone.transform.localScale = -player.transform.localScale/55;
            disparo = true;
            
        }
        
    }

    

}

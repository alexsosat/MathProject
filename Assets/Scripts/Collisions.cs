using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    //Explicar este codigo
    public float vel = 1;
    private Rigidbody2D theRB;
    private void Start()
    {
       
        theRB = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
       theRB.velocity = new Vector2(vel * transform.localScale.x *2.5f, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "tierra" || collision.tag == "Water")
        {
            Destroy(gameObject);
            
        }
    }
}

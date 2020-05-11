using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agua : MonoBehaviour
{
    private GameObject p1;
    private GameObject p2;

    private void Start()
    {
        p1 = GameObject.Find("Player1");
        p2 = GameObject.Find("Player2");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player1")
        {
            p1.GetComponent<Move>().enabled = false;
            p1.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            p1.GetComponent<Rigidbody2D>().gravityScale = 0.1f;
            p1.GetComponent<Vida>().hurtPlayer(1f);

        }

        if (other.tag == "Player2")
        {
            p2.GetComponent<Move>().enabled = false;
            p2.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            p2.GetComponent<Rigidbody2D>().gravityScale = 0.1f;
            p2.GetComponent<Vida>().hurtPlayer(1f);

        }
    }
}

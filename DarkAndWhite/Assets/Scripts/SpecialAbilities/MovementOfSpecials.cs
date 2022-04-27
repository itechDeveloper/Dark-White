using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementOfSpecials : MonoBehaviour
{
    float speed;
    public Rigidbody2D rb;

    public GameObject upSide;
    public GameObject downSide;
    
    void Start()
    {
        speed = -2f;
        rb.gravityScale = .5f;
    }

    void Update()
    {   
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "UpSide")
        {
            rb.gravityScale = .25f;
        }
        else if (collision.gameObject.tag == "DownSide")
        {
            rb.gravityScale = -.5f;
        }
    }
}

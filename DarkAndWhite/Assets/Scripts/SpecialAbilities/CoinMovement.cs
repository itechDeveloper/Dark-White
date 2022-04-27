using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMovement : MonoBehaviour
{
    float speed;
    public Rigidbody2D rb;

    public GameObject upSide;
    public GameObject downSide;
    public GameObject upSide2;
    public GameObject downSide2;
    public GameObject upSide3;
    public GameObject downSide3;

    public GoldSpawner goldSpawner;
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
        if (collision.gameObject.tag == "CoinUpSide")
        {
            rb.gravityScale = .25f;
        }
        else if (collision.gameObject.tag == "CoinDownSide")
        {
            rb.gravityScale = -.5f;
        }

       // if (collision.gameObject.tag == "CoinUpSide2" && goldSpawner.spawnedPointNumber == 2)
       // {
       //     rb.gravityScale = .25f;
       // }
       // else if (collision.gameObject.tag == "CoinDownSide2" && goldSpawner.spawnedPointNumber == 2)
       // {
       //     rb.gravityScale = -.5f;
       // }
       //
       // if (collision.gameObject.tag == "CoinUpSide3" && goldSpawner.spawnedPointNumber == 3)
       // {
       //     rb.gravityScale = .25f;
       // }
       // else if (collision.gameObject.tag == "CoinDownSide3" && goldSpawner.spawnedPointNumber == 3)
       // {
       //     rb.gravityScale = -.5f;
       // }
    }
}

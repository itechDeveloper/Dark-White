using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendulumMove : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public GameObject pendulumMain;

    void Update()
    {
        if (pendulumMain.transform.position.x > -30)
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
    }
}

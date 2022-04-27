using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundThrowingObstacle : MonoBehaviour
{
    public Rigidbody2D rb;
    public float force;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * force * Time.deltaTime, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > -30f) { rb.velocity = new Vector2(speed, rb.velocity.y); }

    }
}

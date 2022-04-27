using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppingObstacle : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    private void Start()
    {
        gameObject.transform.eulerAngles = new Vector3(
          gameObject.transform.eulerAngles.x,
          gameObject.transform.eulerAngles.y,
          gameObject.transform.eulerAngles.z -150f
          );
    }

    void Update()
    {
        if (transform.position.x > -30f)
        {
            rb.velocity = new Vector2(speed, -2f);
        }
    }
}

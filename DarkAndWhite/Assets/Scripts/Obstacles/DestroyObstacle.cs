using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacle : MonoBehaviour
{
    void Update()
    {
        if(transform.position.x < -20f && transform.position.x > -30f)
        {
            Destroy(gameObject);
        }

        if(transform.position.x < -30f)
        {
            transform.position = new Vector2(-40f,0);
        }
    }
}

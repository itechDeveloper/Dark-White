using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHoleThrowingObstacle : MonoBehaviour
{
    public float speed;
    private bool reachedToTarget;

    private Vector2 targetPosition;

    private void Start()
    {
        targetPosition = new Vector2(0, Random.Range(2f,-4f));
    }
    void Update()
    {
        if (transform.position.x > -30f)
        {
            if (transform.position.x >= 0f)
            {
                reachedToTarget = true;
            }

            if (!reachedToTarget)
            {
                transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            }
            else if (reachedToTarget)
            {
                transform.position = Vector2.MoveTowards(transform.position, new Vector2(-10, 0), speed * Time.deltaTime);
                if (transform.position.x <= -9.9f)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}

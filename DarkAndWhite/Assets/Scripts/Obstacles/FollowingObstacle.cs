using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingObstacle : MonoBehaviour
{
    public float speed;
    private Transform target;
    public float chasingDistance;
    
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null && transform.position.x > -30f)
        {
            if (transform.position.x <= -9.5f)
            {
                transform.position = Vector2.MoveTowards(transform.position, new Vector2(-30f, 0f), speed * Time.deltaTime);
            }
            else if (transform.position.x > target.position.x + chasingDistance + 1f)
            {
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }
            else if (transform.position.x <= target.position.x + chasingDistance + 1f)
            {
                transform.position = Vector2.MoveTowards(transform.position, new Vector2(-10f,0f), speed * Time.deltaTime);
            }
        }

        if (target == null && transform.position.x > -9.5f)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(-10f,0f), speed * Time.deltaTime);
        }
        else if (target == null && transform.position.x > -30f)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(-30f, 0f), speed * Time.deltaTime);
        }
    }
}

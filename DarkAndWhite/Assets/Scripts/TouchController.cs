using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
  
    public Transform player;
    private bool touchStart = false;
    internal Vector2 pointA;
    internal Vector2 pointB;
    internal Vector2 pointC;
    internal Vector2 pointBHolder;
    bool changePointA;

    public Transform circle;
    public Transform outerCircle;

    public Vector2 offset;

    public PlayerMovement playerMovement;

    public Health health;

    public float timer;
    public float startTimer;

    private void Start()
    {
        timer = startTimer;
    }
    void Update()
    {
        //NONE
        if (Input.touchCount == 0)
        {
            touchStart = false;
            offset.x = 0f;
            pointA = Vector2.zero;
            pointC = Vector2.zero;
        }


        // TWO INPUTS
        if (Input.touchCount == 2)
        {
            Touch touchA = Input.GetTouch(0);
            Touch touchC = Input.GetTouch(1);

            pointC = Camera.main.ScreenToWorldPoint(touchC.position);
            
            if (changePointA)
            {
                pointA = Camera.main.ScreenToWorldPoint(touchA.position);

                if (pointA.x <= (Camera.main.transform.position.x / 2))
                { 
                    circle.transform.position = pointA;
                    outerCircle.transform.position = pointA;
                    circle.GetComponent<SpriteRenderer>().enabled = true;
                    outerCircle.GetComponent<SpriteRenderer>().enabled = true;
                }
            }

            if (playerMovement.isGrounded && Input.GetMouseButtonDown(1) && pointC.x > (Camera.main.transform.position.x / 2))
            {
                timer = startTimer;
            }
            if (playerMovement.direction != 0)
            {
                timer = startTimer;
            }

            if (pointC.x > 0 && !playerMovement.isJumping && !playerMovement.isGrounded && playerMovement.dashTimeCoolDown <= 0)
            {
                playerMovement.canDash = true;
            }
            else if (pointC.x < 0)
            {
                playerMovement.canDash = false;
            }

            if (Input.GetMouseButtonUp(0))
            {
                changePointA = true;
            }

            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            else if (Input.GetMouseButton(0) && pointA.x <= (Camera.main.transform.position.x / 2) && health.health > 0)
            {
                touchStart = true;
                pointB = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
            }
            else
            {
                touchStart = false;
                offset.x = 0;
                circle.GetComponent<SpriteRenderer>().enabled = false;
                outerCircle.GetComponent<SpriteRenderer>().enabled = false;
            }
        }

        // ONLY ONE INPUT
        else if (Input.touchCount == 1)
        {
           
            if (Input.GetMouseButtonDown(0) && health.health > 0)
            {
                changePointA = false;
                Touch touchA = Input.GetTouch(0);
                pointA = Camera.main.ScreenToWorldPoint(touchA.position);
                if (pointA.x <= (Camera.main.transform.position.x / 2))
                {
                    circle.transform.position = pointA;
                    outerCircle.transform.position = pointA;
                    circle.GetComponent<SpriteRenderer>().enabled = true;
                    outerCircle.GetComponent<SpriteRenderer>().enabled = true;
                }

                if (pointA.x > 0 && !playerMovement.isJumping && !playerMovement.isGrounded && playerMovement.dashTimeCoolDown <= 0)
                {
                    playerMovement.canDash = true;
                }
                else if (pointA.x < 0)
                {
                    playerMovement.canDash = false;
                }
            }

            if (Input.GetMouseButtonUp(0))
            {
                changePointA = true;
            }

            if (Input.GetMouseButton(0) && pointA.x <= (Camera.main.transform.position.x / 2) && health.health > 0)
            {
                touchStart = true;
                //Debug.Log("1:  "+ (Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z)).x));
                if (Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z)).x < 0)
                {
                    pointB = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
                }
            }

            else
            {
                touchStart = false;
                offset.x = 0;
                circle.GetComponent<SpriteRenderer>().enabled = false;
                outerCircle.GetComponent<SpriteRenderer>().enabled = false;
            }
        }

          //
       // if (Input.GetMouseButtonDown(0) && health.health > 0)
       // {
       //     pointA = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
       //
       //     if (pointA.x > 0 && !playerMovement.isJumping && !playerMovement.isGrounded && playerMovement.dashTimeCoolDown <= 0)
       //     {
       //         playerMovement.canDash = true;
       //     }
       //     else if (pointA.x < 0)
       //     {
       //         playerMovement.canDash = false;    
       //     }
       //
       //
       //     if (pointA.x <= (Camera.main.transform.position.x / 2) && health.health > 0)
       //     {
       //         circle.transform.position = pointA;
       //         outerCircle.transform.position = pointA;
       //         circle.GetComponent<SpriteRenderer>().enabled = true;
       //         outerCircle.GetComponent<SpriteRenderer>().enabled = true;
       //     }
       // }
       //
       // if (Input.GetMouseButton(0) && pointA.x <= (Camera.main.transform.position.x / 2) && health.health > 0)
       // {
       //     touchStart = true;
       //     pointB = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
       // }
       // else
       // {
       //     touchStart = false;
       //     offset.x = 0;
       // }     
    }

    private void FixedUpdate()
    {
        if (touchStart)
        {
            offset = pointB - pointA;
            Vector2 direction = Vector2.ClampMagnitude(offset, 1f);
            circle.transform.position = new Vector2(pointA.x + direction.x, pointA.y);         
        }
        else
        {   
            circle.GetComponent<SpriteRenderer>().enabled = false;
            outerCircle.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}

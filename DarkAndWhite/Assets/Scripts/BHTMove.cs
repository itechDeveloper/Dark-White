using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BHTMove : MonoBehaviour
{
    public GameObject blackHole;

    float scaler;
    private float startingDistance;
    private Vector2 startingScale;
    public float speed;
    float curDistance;

    public Clock clock;
    public string platformColor;

    public Sprite activeSpriteWhite, diactiveSpriteWhite;
    public Sprite activeSpriteBlack, diactiveSpriteBlack;
    void Start()
    {
        startingDistance = Vector2.Distance(blackHole.transform.position, transform.position);
        startingScale = transform.localScale;
    }

    void Update()
    {
        
        if (transform.position.x < 20f)
        {
            transform.position = Vector2.MoveTowards(transform.position, blackHole.transform.position, speed * Time.deltaTime);
            Scale();
            SpriteActivation();

            if (transform.position.x < blackHole.transform.position.x + .2f)
            {
                Destroy(gameObject);
            }
        }   
    }

    void Scale()
    {
        curDistance =  Vector2.Distance(blackHole.transform.position, transform.position);
        scaler = curDistance / startingDistance;
        transform.localScale = startingScale * scaler;
    }

    void SpriteActivation()
    {
        if (clock.white)
        {
            if (platformColor == "White")
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = activeSpriteWhite;
            }

            if (platformColor == "Black")
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = diactiveSpriteBlack;
                gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
            }
        }
        else if (!clock.white)
        {
            if (platformColor == "White")
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = diactiveSpriteWhite;
                gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
            }
            if (platformColor == "Black")
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = activeSpriteBlack;
                gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);

            }
        }
    }
}

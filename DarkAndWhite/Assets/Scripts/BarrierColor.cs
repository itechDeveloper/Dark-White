using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierColor : MonoBehaviour
{
    public Clock clock;
    public Animator animator;
    public float animatorSpeed;

    void Start()
    {
        animator.speed = animatorSpeed;
    }
    void Update()
    {
        gameObject.transform.localScale = new Vector2(-.9f,.9f);

        if (clock.white)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 1);
        }

        if (!clock.white)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        }
    }
}

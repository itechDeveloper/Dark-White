using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoBackGround : MonoBehaviour
{
    public AudioSource specialses;
    public Clock arkaplan;
    public bool specialplatform;
    public NoBgTiming bg;

    public Clock clock;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            clock.activeNoBg = true;
            specialses.Play();
            bg.bgnoo = true;
            specialplatform = true;
            Destroy(gameObject);
        }  
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
    public AudioSource specialses;
    public MagnetTiming say;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            specialses.Play();
            say.sayma = true;
            Destroy(gameObject);
        }      
    }
}

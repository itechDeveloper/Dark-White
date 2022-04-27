using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kalkan : MonoBehaviour
{
    public AudioSource specialses;
    public Health can;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            specialses.Play();
           can.health   += 1;
            if(can.health > 2)
            {
                can.health = 2;
            }
            Destroy(gameObject);
        }
    }

}

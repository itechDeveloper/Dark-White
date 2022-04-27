using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitPlayer : MonoBehaviour
{
    public Health health;

    public Clock clock;
    public GameObject deathParticle;
    public GameObject deathParticleBlack;
    public Rigidbody2D rb;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            health.health -= 1;
            if (!clock.white)
            {
                Instantiate(deathParticle, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
            else if (clock.white)
            {
                Instantiate(deathParticleBlack, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }         
        }

        if (transform.position.x < -35f)
        {
            transform.position = new Vector3(-40f,0);
        }
    }   
}

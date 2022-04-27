using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float fieldImpact;
    public LayerMask LayerToHit;
    public Health health;

    public GameObject explosionEffect;
    bool findPlayer;


    void explode(int x)
    {
        findPlayer  = Physics2D.OverlapCircle(transform.position, fieldImpact, LayerToHit);
        if (x == 1)
        {
            health.health = 0;
        }else if (x == 2)
        {
            if (findPlayer)
            {
                health.health -= 1;
            }
        }

        Vector2 whereToSpawn = new Vector2(transform.position.x, transform.position.y - .7f);
        GameObject ExplosionEffect = Instantiate(explosionEffect, whereToSpawn, Quaternion.identity);
        Destroy(ExplosionEffect, .5f);
        Destroy(gameObject);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, fieldImpact);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            explode(1);
        }else if (collision.CompareTag("WhitePlatform") || collision.CompareTag("BlackPlatform"))
        {
            explode(2);
        }
    }
}

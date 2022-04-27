using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldScript : MonoBehaviour
{
    public GoldScore gold;
    public AudioSource ses;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            gold.goldscore += 1;
            ses.Play();
            Destroy(gameObject);
        }
     
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public Transform playerTransform;
    public float moveSpeed = 17f;
    coinmove coinMoveScript;
    // Start is called before the first frame update
    void Start()
    {
        if (playerTransform != null)
        {
            playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        }    
        coinMoveScript = gameObject.GetComponent<coinmove>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "CoinDedector")
        {
            coinMoveScript.enabled = true;
        }
    }
}

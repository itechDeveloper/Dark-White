using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinmove : MonoBehaviour
{
    coin coinScrpit;
    public GoldScore gold;

    // Start is called before the first frame update
    void Start()
    {
        coinScrpit = gameObject.GetComponent<coin>();
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = Vector2.MoveTowards(transform.position, coinScrpit.playerTransform.position,
           coinScrpit.moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "PlayerBubble")
        {
            Destroy(gameObject);
            gold.goldscore += 1;
        }
    }
}

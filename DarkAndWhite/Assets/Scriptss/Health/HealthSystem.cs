using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public AudioSource gameoverses;
    bool gameovervoicePlayed;
    public PlayerMovement player;
    public TipController tips;
    public GameObject gameovercontainer;
    public Health can;
    public GameObject sagustaltın;
    public GameObject sagustzaman;
    public GameObject pausebtn;
    public GameObject barrier;

    void Start()
    {
        can.health = 1;
        gameovercontainer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(can.health <= 0)
        {
            if (!gameovervoicePlayed)
            {
                gameoverses.Play();
                gameovervoicePlayed = true;
            }
            gameovercontainer.SetActive(true);
            pausebtn.SetActive(false);
            tips.gameovertip = true;
            sagustaltın.SetActive(false);
            sagustzaman.SetActive(false);
            if (GameObject.Find("player") != null)
            {
                player.capsuleCollider.enabled = false;
            }  
        }else if (can.health == 1)
        {
            gameovervoicePlayed = false;
            player.capsuleCollider.enabled = true;
            barrier.SetActive(false);
        }
        else if (can.health == 2)
        {
            gameovervoicePlayed = false;
            player.capsuleCollider.enabled = true;
            barrier.SetActive(true);
        }else if (can.health > 2)
        {
            can.health = 2;
        }
    }
}

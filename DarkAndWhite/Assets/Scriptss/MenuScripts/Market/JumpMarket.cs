using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpMarket : MonoBehaviour
{
    public BarController speedbarkontrol;
    public PlayerMovement player;
    public MarketMenuMoney para;
 
    public GameObject jumpbuybtn1;
    public GameObject jumpbuybtn2;
    public GameObject jumpbuybtn3;
    public GameObject jumpbuybtn4;

    public Text notenough;
    public Text bought;
    public int fiyat1 = 10;
    public int fiyat2 = 100;
    public int fiyat3 = 1000;

    public GameObject afterBought1;
    public GameObject afterBought2;
    public GameObject afterBought3;

    public SpeedMarket speedMarket;
    public int costOfJump;
    bool boughtJump;
    float buyableAgain;
    float startBuyTime;

    private void Start()
    {
        startBuyTime = 1f;
    }
    private void Update()
    {
        costOfJump = PlayerPrefs.GetInt("CostOfJump");

        if (buyableAgain > 0)
        {
            buyableAgain -= Time.deltaTime;
        }
        else
        {
            buyableAgain = startBuyTime;
            boughtJump = false;
        }
    }

    public void jumpafterbought1()
    {
        if (para.moneyb >= 100 && costOfJump <= 0 && !boughtJump)
        {
            speedbarkontrol.kontrolspeed = PlayerPrefs.GetInt("kontrolSpeed");
            speedbarkontrol.kontrolspeed -= 1;
            PlayerPrefs.SetInt("kontrolSpeed", speedbarkontrol.kontrolspeed);
            para.moneyb = PlayerPrefs.GetInt("HighScore");
            para.moneyb -= 100;
            PlayerPrefs.SetInt("HighScore", para.moneyb);

            costOfJump = PlayerPrefs.GetInt("CostOfJump");
            costOfJump += 1;
            PlayerPrefs.SetInt("CostOfJump", costOfJump);

            speedMarket.costOfSpeed = PlayerPrefs.GetInt("CostOfSpeed");
            speedMarket.costOfSpeed -= 1;
            PlayerPrefs.SetInt("CostOfSpeed", speedMarket.costOfSpeed);

            player.speed = PlayerPrefs.GetFloat("Speed");
            player.jumpVelocity = PlayerPrefs.GetFloat("JumpVelocity");
            player.speed -= .5f;
            player.jumpVelocity += .5f;
            PlayerPrefs.SetFloat("Speed", player.speed);
            PlayerPrefs.SetFloat("JumpVelocity", player.jumpVelocity);

            afterBought1.gameObject.SetActive(false);
            afterBought2.gameObject.SetActive(false);
            afterBought3.gameObject.SetActive(false);
            jumpbuybtn1.gameObject.SetActive(false);
            jumpbuybtn2.gameObject.SetActive(true);
            bought.gameObject.SetActive(true);

            boughtJump = true;
        }
        else if(costOfJump == 0 && !boughtJump)
        {
            afterBought1.gameObject.SetActive(false);
            bought.gameObject.SetActive(false);
            notenough.gameObject.SetActive(true);
        }
    }

    public void jumpafterbought2()
    {
        if (para.moneyb >= 300 && costOfJump == 1 && !boughtJump)
        {
            speedbarkontrol.kontrolspeed = PlayerPrefs.GetInt("kontrolSpeed");
            speedbarkontrol.kontrolspeed -= 1;
            PlayerPrefs.SetInt("kontrolSpeed", speedbarkontrol.kontrolspeed);
            para.moneyb = PlayerPrefs.GetInt("HighScore");
            para.moneyb -= 300;
            PlayerPrefs.SetInt("HighScore", para.moneyb);

            costOfJump = PlayerPrefs.GetInt("CostOfJump");
            costOfJump += 1;
            PlayerPrefs.SetInt("CostOfJump", costOfJump);

            speedMarket.costOfSpeed = PlayerPrefs.GetInt("CostOfSpeed");
            speedMarket.costOfSpeed -= 1;
            PlayerPrefs.SetInt("CostOfSpeed", speedMarket.costOfSpeed);

            player.speed = PlayerPrefs.GetFloat("Speed");
            player.jumpVelocity = PlayerPrefs.GetFloat("JumpVelocity");
            player.speed -= .5f;
            player.jumpVelocity += .5f;
            PlayerPrefs.SetFloat("Speed", player.speed);
            PlayerPrefs.SetFloat("JumpVelocity", player.jumpVelocity);


            afterBought1.gameObject.SetActive(false);
            afterBought2.gameObject.SetActive(false);
            afterBought3.gameObject.SetActive(false);
            jumpbuybtn2.gameObject.SetActive(false);
            jumpbuybtn3.gameObject.SetActive(true);
            bought.gameObject.SetActive(true);

            boughtJump = true;
        }
        else if (costOfJump == 1 && !boughtJump)
        {
            afterBought2.gameObject.SetActive(false);
            bought.gameObject.SetActive(false);
            notenough.gameObject.SetActive(true);
        }
    }

    public void jumpafterbought3()
    {
        if (para.moneyb >= 1000 && costOfJump == 2 && !boughtJump)
        {
            
            speedbarkontrol.kontrolspeed = PlayerPrefs.GetInt("kontrolSpeed");
            speedbarkontrol.kontrolspeed -= 1;
            PlayerPrefs.SetInt("kontrolSpeed", speedbarkontrol.kontrolspeed);

            para.moneyb = PlayerPrefs.GetInt("HighScore");
            para.moneyb -= 1000;
            PlayerPrefs.SetInt("HighScore", para.moneyb);

            speedMarket.costOfSpeed = PlayerPrefs.GetInt("CostOfSpeed");
            speedMarket.costOfSpeed -= 1;
            PlayerPrefs.SetInt("CostOfSpeed", speedMarket.costOfSpeed);

            player.speed = PlayerPrefs.GetFloat("Speed");
            player.jumpVelocity = PlayerPrefs.GetFloat("JumpVelocity");
            player.speed -= .5f;
            player.jumpVelocity += .5f;
            PlayerPrefs.SetFloat("Speed", player.speed);
            PlayerPrefs.SetFloat("JumpVelocity", player.jumpVelocity);

            costOfJump = PlayerPrefs.GetInt("CostOfJump");
            costOfJump += 1;
            PlayerPrefs.SetInt("CostOfJump", costOfJump);

            afterBought1.gameObject.SetActive(false);
            afterBought2.gameObject.SetActive(false);
            afterBought3.gameObject.SetActive(false);
            jumpbuybtn3.gameObject.SetActive(false);
            jumpbuybtn4.gameObject.SetActive(true);
            bought.gameObject.SetActive(true);
           
               
        }
        else if (costOfJump == 2 && speedbarkontrol.kontrolspeed == -3 && !boughtJump)
        {

            afterBought1.gameObject.SetActive(false);
            afterBought2.gameObject.SetActive(false);
            afterBought3.gameObject.SetActive(false);
            bought.gameObject.SetActive(false);
            notenough.gameObject.SetActive(true);
        }
    }

}
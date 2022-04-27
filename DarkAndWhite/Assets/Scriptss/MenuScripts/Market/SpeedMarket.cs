using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedMarket : MonoBehaviour
{
    public BarController speedbarkontrol;
   
    public PlayerMovement player;
    public MarketMenuMoney para;
 
    public GameObject speedbuybtn1;
    public GameObject speedbuybtn2;
    public GameObject speedbuybtn3;
    public GameObject speedbuybtn4;

    public Text notenough;
    public Text bought;
    public int fiyat1 = 10;
    public int fiyat2 = 100;
    public int fiyat3 = 1000;

    public GameObject afterBought1;
    public GameObject afterBought2;
    public GameObject afterBought3;

    public JumpMarket jumpMarket;
    public int costOfSpeed;
    bool boughtSpeed;
    float buyableAgain;
    float startBuyTime;

    private void Start()
    {       
        startBuyTime = 1f;
    }
    private void Update()
    {  
        costOfSpeed = PlayerPrefs.GetInt("CostOfSpeed");



        if (buyableAgain > 0)
        {
            buyableAgain -= Time.deltaTime;
        }
        else
        {
            buyableAgain = startBuyTime;
            boughtSpeed = false;
        }
    }

    public void speedafterbought1()
    {
        if (para.moneyb >= 100 && costOfSpeed <= 0 && !boughtSpeed)
        {
            speedbarkontrol.kontrolspeed = PlayerPrefs.GetInt("kontrolSpeed");
            speedbarkontrol.kontrolspeed += 1;
            PlayerPrefs.SetInt("kontrolSpeed", speedbarkontrol.kontrolspeed);
            para.moneyb = PlayerPrefs.GetInt("HighScore");
            para.moneyb -= 100;
            PlayerPrefs.SetInt("HighScore", para.moneyb);

            costOfSpeed = PlayerPrefs.GetInt("CostOfSpeed");
            costOfSpeed += 1;
            PlayerPrefs.SetInt("CostOfSpeed", costOfSpeed);

            jumpMarket.costOfJump = PlayerPrefs.GetInt("CostOfJump");
            jumpMarket.costOfJump -= 1;
            PlayerPrefs.SetInt("CostOfJump", jumpMarket.costOfJump);

            player.speed = PlayerPrefs.GetFloat("Speed");
            player.jumpVelocity = PlayerPrefs.GetFloat("JumpVelocity");
            player.speed += .5f;
            player.jumpVelocity -= .5f;
            PlayerPrefs.SetFloat("Speed", player.speed);
            PlayerPrefs.SetFloat("JumpVelocity", player.jumpVelocity);

            afterBought1.gameObject.SetActive(false);
            afterBought2.gameObject.SetActive(false);
            afterBought3.gameObject.SetActive(false);
            speedbuybtn1.gameObject.SetActive(false);
            speedbuybtn2.gameObject.SetActive(true);
            bought.gameObject.SetActive(true);

            boughtSpeed = true;
        }
        else if (costOfSpeed == 0 && !boughtSpeed)
        {
            afterBought1.gameObject.SetActive(false);
            bought.gameObject.SetActive(false);
            notenough.gameObject.SetActive(true);
        }
    }

    public void speedafterbought2()
    {
        if (para.moneyb >= 300 && costOfSpeed == 1 && !boughtSpeed)
        {
            speedbarkontrol.kontrolspeed = PlayerPrefs.GetInt("kontrolSpeed");
            speedbarkontrol.kontrolspeed += 1;
            PlayerPrefs.SetInt("kontrolSpeed", speedbarkontrol.kontrolspeed);
            para.moneyb = PlayerPrefs.GetInt("HighScore");
            para.moneyb -= 300;
            PlayerPrefs.SetInt("HighScore", para.moneyb);

            costOfSpeed = PlayerPrefs.GetInt("CostOfSpeed");
            costOfSpeed += 1;
            PlayerPrefs.SetInt("CostOfSpeed", costOfSpeed);

            jumpMarket.costOfJump = PlayerPrefs.GetInt("CostOfJump");
            jumpMarket.costOfJump -= 1;
            PlayerPrefs.SetInt("CostOfJump", jumpMarket.costOfJump);

            player.speed = PlayerPrefs.GetFloat("Speed");
            player.jumpVelocity = PlayerPrefs.GetFloat("JumpVelocity");
            player.speed += .5f;
            player.jumpVelocity -= .5f;
            PlayerPrefs.SetFloat("Speed", player.speed);
            PlayerPrefs.SetFloat("JumpVelocity", player.jumpVelocity);

            afterBought1.gameObject.SetActive(false);
            afterBought2.gameObject.SetActive(false);
            afterBought3.gameObject.SetActive(false);
            speedbuybtn2.gameObject.SetActive(false);
            speedbuybtn3.gameObject.SetActive(true);
            bought.gameObject.SetActive(true);

            boughtSpeed = true;
        }
        else if (costOfSpeed == 1 && !boughtSpeed)
        {
            afterBought2.gameObject.SetActive(false);
            bought.gameObject.SetActive(false);
            notenough.gameObject.SetActive(true);
        }
    }

    public void speedafterbought3()
    {
        if (para.moneyb >= 1000 && costOfSpeed == 2 && !boughtSpeed)
        {
            speedbarkontrol.kontrolspeed = PlayerPrefs.GetInt("kontrolSpeed");
            speedbarkontrol.kontrolspeed += 1;
            PlayerPrefs.SetInt("kontrolSpeed", speedbarkontrol.kontrolspeed);
            para.moneyb = PlayerPrefs.GetInt("HighScore");
            para.moneyb -= 1000;
            PlayerPrefs.SetInt("HighScore", para.moneyb);

            player.speed = PlayerPrefs.GetFloat("Speed");
            player.jumpVelocity = PlayerPrefs.GetFloat("JumpVelocity");
            player.speed += .5f;
            player.jumpVelocity -= .5f;
            PlayerPrefs.SetFloat("Speed", player.speed);
            PlayerPrefs.SetFloat("JumpVelocity", player.jumpVelocity);

            costOfSpeed = PlayerPrefs.GetInt("CostOfSpeed");
            costOfSpeed += 1;
            PlayerPrefs.SetInt("CostOfSpeed", costOfSpeed);

            jumpMarket.costOfJump = PlayerPrefs.GetInt("CostOfJump");
            jumpMarket.costOfJump -= 1;
            PlayerPrefs.SetInt("CostOfJump", jumpMarket.costOfJump);

            afterBought1.gameObject.SetActive(false);
            afterBought2.gameObject.SetActive(false);
            afterBought3.gameObject.SetActive(false);              
            speedbuybtn3.gameObject.SetActive(false);
            speedbuybtn4.gameObject.SetActive(false);
            bought.gameObject.SetActive(true);

            boughtSpeed = true;
        }
        else if (costOfSpeed == 2 && speedbarkontrol.kontrolspeed == 3 && !boughtSpeed)
        {
            afterBought1.gameObject.SetActive(false);
            afterBought2.gameObject.SetActive(false);
            afterBought3.gameObject.SetActive(false);
            bought.gameObject.SetActive(false);
            notenough.gameObject.SetActive(true);
        }
    }

}
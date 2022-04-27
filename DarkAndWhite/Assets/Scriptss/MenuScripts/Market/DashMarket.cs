using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DashMarket : MonoBehaviour
{
    public BarController dashdownkontrol;
    public PlayerMovement player;
    public MarketMenuMoney para;
  
    public GameObject dashbuybtn1;
    public GameObject dashbuybtn2;
    public GameObject dashbuybtn3;
    public GameObject dashbuybtn4;

    public Text notenough;
    public Text bought;
    public int fiyat1 = 10;
    public int fiyat2 = 100;
    public int fiyat3 = 1000;

    public DashDownMarket dashDownMarket;
    public int costOfDashUp;
    bool boughtDashUp;
    float buyableAgain;
    float startBuyTime;

    public GameObject afterBought1;
    public GameObject afterBought2;
    public GameObject afterBought3;

    private void Start()
    {
        startBuyTime = 1f;
    }
    private void Update()
    {
        costOfDashUp = PlayerPrefs.GetInt("CostOfDashUp");

        if (buyableAgain > 0)
        {
            buyableAgain -= Time.deltaTime;
        }
        else
        {
            buyableAgain = startBuyTime;
            boughtDashUp = false;
        }
    }

    public void dashafterbought1()
    {
        if (para.moneyb >= 100 && costOfDashUp <= 0 && !boughtDashUp)
        {
            dashdownkontrol.kontroldash = PlayerPrefs.GetInt("kontrolDash");
            dashdownkontrol.kontroldash += 1;
            PlayerPrefs.SetInt("kontrolDash", dashdownkontrol.kontroldash);

            para.moneyb = PlayerPrefs.GetInt("HighScore");
            para.moneyb -= 100;
            PlayerPrefs.SetInt("HighScore", para.moneyb);

            costOfDashUp = PlayerPrefs.GetInt("CostOfDashUp");
            costOfDashUp += 1;
            PlayerPrefs.SetInt("CostOfDashUp", costOfDashUp);

            dashDownMarket.costOfDashDown = PlayerPrefs.GetInt("CostOfDashDown");
            dashDownMarket.costOfDashDown -= 1;
            PlayerPrefs.SetInt("CostOfDashDown", dashDownMarket.costOfDashDown);

            player.dashSpeed = PlayerPrefs.GetFloat("DashSpeed");
            player.startDashTimeCoolDown = PlayerPrefs.GetFloat("DashCoolDown");
            player.dashSpeed += 2f;
            player.startDashTimeCoolDown += .5f;
            PlayerPrefs.SetFloat("DashSpeed", player.dashSpeed);
            PlayerPrefs.SetFloat("DashCoolDown", player.startDashTimeCoolDown);


            afterBought1.gameObject.SetActive(false);
            afterBought2.gameObject.SetActive(false);
            afterBought3.gameObject.SetActive(false);
            dashbuybtn1.gameObject.SetActive(false);
            dashbuybtn2.gameObject.SetActive(true);
            bought.gameObject.SetActive(true);

            boughtDashUp = true;
        }
        else if(costOfDashUp == 0 && !boughtDashUp)
        {
            bought.gameObject.SetActive(false);
            notenough.gameObject.SetActive(true);
            afterBought1.gameObject.SetActive(false);

        }

    }

    public void dashafterbought2()
    {
        if (para.moneyb >= 300 && costOfDashUp == 1 && !boughtDashUp)
        {
            dashdownkontrol.kontroldash = PlayerPrefs.GetInt("kontrolDash");
            dashdownkontrol.kontroldash += 1;
            PlayerPrefs.SetInt("kontrolDash", dashdownkontrol.kontroldash);

            para.moneyb = PlayerPrefs.GetInt("HighScore");
            para.moneyb -= 300;
            PlayerPrefs.SetInt("HighScore", para.moneyb);

            costOfDashUp = PlayerPrefs.GetInt("CostOfDashUp");
            costOfDashUp += 1;
            PlayerPrefs.SetInt("CostOfDashUp", costOfDashUp);

            dashDownMarket.costOfDashDown = PlayerPrefs.GetInt("CostOfDashDown");
            dashDownMarket.costOfDashDown -= 1;
            PlayerPrefs.SetInt("CostOfDashDown", dashDownMarket.costOfDashDown);

            player.dashSpeed = PlayerPrefs.GetFloat("DashSpeed");
            player.startDashTimeCoolDown = PlayerPrefs.GetFloat("DashCoolDown");
            player.dashSpeed += 2f;
            player.startDashTimeCoolDown += .5f;
            PlayerPrefs.SetFloat("DashSpeed", player.dashSpeed);
            PlayerPrefs.SetFloat("DashCoolDown", player.startDashTimeCoolDown);


            afterBought1.gameObject.SetActive(false);
            afterBought2.gameObject.SetActive(false);
            afterBought3.gameObject.SetActive(false);
            dashbuybtn2.gameObject.SetActive(false);
            dashbuybtn3.gameObject.SetActive(true);
            bought.gameObject.SetActive(true);

            boughtDashUp = true;
        }
        else if (costOfDashUp == 1 && !boughtDashUp)
        {
            bought.gameObject.SetActive(false);
            notenough.gameObject.SetActive(true);
            afterBought2.gameObject.SetActive(false);
        }
    }

    public void dashafterbought3()
    {
        if (para.moneyb >= 1000 && costOfDashUp == 2 && !boughtDashUp)
        {
            dashdownkontrol.kontroldash = PlayerPrefs.GetInt("kontrolDash");
            dashdownkontrol.kontroldash += 1;
            PlayerPrefs.SetInt("kontrolDash", dashdownkontrol.kontroldash);

            para.moneyb = PlayerPrefs.GetInt("HighScore");
            para.moneyb -= 1000;
            PlayerPrefs.SetInt("HighScore", para.moneyb);

            player.dashSpeed = PlayerPrefs.GetFloat("DashSpeed");
            player.startDashTimeCoolDown = PlayerPrefs.GetFloat("DashCoolDown");
            player.dashSpeed += 2f;
            player.startDashTimeCoolDown += .5f;
            PlayerPrefs.SetFloat("DashSpeed", player.dashSpeed);
            PlayerPrefs.SetFloat("DashCoolDown", player.startDashTimeCoolDown);

            dashDownMarket.costOfDashDown = PlayerPrefs.GetInt("CostOfDashDown");
            dashDownMarket.costOfDashDown -= 1;
            PlayerPrefs.SetInt("CostOfDashDown", dashDownMarket.costOfDashDown);

            costOfDashUp = PlayerPrefs.GetInt("CostOfDashUp");
            costOfDashUp += 1;
            PlayerPrefs.SetInt("CostOfDashUp", costOfDashUp);
 
            afterBought1.gameObject.SetActive(false);
            afterBought2.gameObject.SetActive(false);
            afterBought3.gameObject.SetActive(false);
            dashbuybtn3.gameObject.SetActive(false);
            dashbuybtn4.gameObject.SetActive(true);
            bought.gameObject.SetActive(true);  
        }
        else if (costOfDashUp == 2 && dashdownkontrol.kontroldash == 3 && !boughtDashUp)
        {
            bought.gameObject.SetActive(false);
            notenough.gameObject.SetActive(true);
            
            afterBought1.gameObject.SetActive(false);
            afterBought2.gameObject.SetActive(false);
            afterBought3.gameObject.SetActive(false);
        }
    }

}
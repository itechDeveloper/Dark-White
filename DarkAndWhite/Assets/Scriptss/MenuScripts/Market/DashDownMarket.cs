using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DashDownMarket : MonoBehaviour
{
    public BarController dashbdownkontrol;
    public PlayerMovement player;
    public MarketMenuMoney para;

    public GameObject dashdownbuybtn1;
    public GameObject dashdownbuybtn2;
    public GameObject dashdownbuybtn3;
    public GameObject dashdownbuybtn4;

    public Text notenough;
    public Text bought;
    public int fiyat1 = 10;
    public int fiyat2 = 100;
    public int fiyat3 = 1000;

    public DashMarket dashMarket;
    public int costOfDashDown;
    bool boughtDashDown;
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
        costOfDashDown = PlayerPrefs.GetInt("CostOfDashDown");

        if (buyableAgain > 0)
        {
            buyableAgain -= Time.deltaTime;
        }
        else
        {
            buyableAgain = startBuyTime;
            boughtDashDown = false;
        }
    }

    public void dashdownafterbought1()
    {
        if (para.moneyb >= 100 && costOfDashDown <= 0 && !boughtDashDown)
        {
            dashbdownkontrol.kontroldash = PlayerPrefs.GetInt("kontrolDash");
            dashbdownkontrol.kontroldash -= 1;
            PlayerPrefs.SetInt("kontrolDash", dashbdownkontrol.kontroldash);

            para.moneyb = PlayerPrefs.GetInt("HighScore");
            para.moneyb -= 100;
            PlayerPrefs.SetInt("HighScore", para.moneyb);

            costOfDashDown = PlayerPrefs.GetInt("CostOfDashDown");
            costOfDashDown += 1;
            PlayerPrefs.SetInt("CostOfDashDown", costOfDashDown);

            dashMarket.costOfDashUp = PlayerPrefs.GetInt("CostOfDashUp");
            dashMarket.costOfDashUp -= 1;
            PlayerPrefs.SetInt("CostOfDashUp", dashMarket.costOfDashUp);

            player.dashSpeed = PlayerPrefs.GetFloat("DashSpeed");
            player.startDashTimeCoolDown = PlayerPrefs.GetFloat("DashCoolDown");
            player.dashSpeed -= 2f;
            player.startDashTimeCoolDown -= .5f;
            PlayerPrefs.SetFloat("DashSpeed", player.dashSpeed);
            PlayerPrefs.SetFloat("DashCoolDown", player.startDashTimeCoolDown);


            afterBought1.gameObject.SetActive(false);
            afterBought2.gameObject.SetActive(false);
            afterBought3.gameObject.SetActive(false);
            dashdownbuybtn1.gameObject.SetActive(false);
            dashdownbuybtn2.gameObject.SetActive(true);
            bought.gameObject.SetActive(true);

            boughtDashDown = true;
        }
        else if (costOfDashDown == 0 && !boughtDashDown)
        {
            bought.gameObject.SetActive(false);
            notenough.gameObject.SetActive(true);
            afterBought1.gameObject.SetActive(false);
        }
    }

    public void dashdownafterbought2()
    {
        if (para.moneyb >= 300 && costOfDashDown == 1 && !boughtDashDown)
        {
            dashbdownkontrol.kontroldash = PlayerPrefs.GetInt("kontrolDash");
            dashbdownkontrol.kontroldash -= 1;
            PlayerPrefs.SetInt("kontrolDash", dashbdownkontrol.kontroldash);

            para.moneyb = PlayerPrefs.GetInt("HighScore");
            para.moneyb -= 300;
            PlayerPrefs.SetInt("HighScore", para.moneyb);

            costOfDashDown = PlayerPrefs.GetInt("CostOfDashDown");
            costOfDashDown += 1;
            PlayerPrefs.SetInt("CostOfDashDown", costOfDashDown);

            dashMarket.costOfDashUp = PlayerPrefs.GetInt("CostOfDashUp");
            dashMarket.costOfDashUp -= 1;
            PlayerPrefs.SetInt("CostOfDashUp", dashMarket.costOfDashUp);

            player.dashSpeed = PlayerPrefs.GetFloat("DashSpeed");
            player.startDashTimeCoolDown = PlayerPrefs.GetFloat("DashCoolDown");
            player.dashSpeed -= 2f;
            player.startDashTimeCoolDown -= .5f;
            PlayerPrefs.SetFloat("DashSpeed", player.dashSpeed);
            PlayerPrefs.SetFloat("DashCoolDown", player.startDashTimeCoolDown);

            dashdownbuybtn2.gameObject.SetActive(false);
            dashdownbuybtn3.gameObject.SetActive(true);
            bought.gameObject.SetActive(true);

            afterBought1.gameObject.SetActive(false);
            afterBought2.gameObject.SetActive(false);
            afterBought3.gameObject.SetActive(false);

            boughtDashDown = true;
        }
        else if (costOfDashDown == 1 && !boughtDashDown)
        {
            bought.gameObject.SetActive(false);
            notenough.gameObject.SetActive(true);
            afterBought2.gameObject.SetActive(false);
        }
    }

    public void dashdownafterbought3()
    {
        if (para.moneyb >= 1000 && costOfDashDown == 2 && !boughtDashDown)
        {
            dashbdownkontrol.kontroldash = PlayerPrefs.GetInt("kontrolDash");
            dashbdownkontrol.kontroldash -= 1;
            PlayerPrefs.SetInt("kontrolDash", dashbdownkontrol.kontroldash);

            para.moneyb = PlayerPrefs.GetInt("HighScore");
            para.moneyb -= 1000;
            PlayerPrefs.SetInt("HighScore", para.moneyb);

            player.dashSpeed = PlayerPrefs.GetFloat("DashSpeed");
            player.startDashTimeCoolDown = PlayerPrefs.GetFloat("DashCoolDown");
            player.dashSpeed -= 2f;
            player.startDashTimeCoolDown -= .5f;
            PlayerPrefs.SetFloat("DashSpeed", player.dashSpeed);
            PlayerPrefs.SetFloat("DashCoolDown", player.startDashTimeCoolDown);

            costOfDashDown = PlayerPrefs.GetInt("CostOfDashDown");
            costOfDashDown += 1;
            PlayerPrefs.SetInt("CostOfDashDown", costOfDashDown);

            dashMarket.costOfDashUp = PlayerPrefs.GetInt("CostOfDashUp");
            dashMarket.costOfDashUp -= 1;
            PlayerPrefs.SetInt("CostOfDashUp", dashMarket.costOfDashUp);

            afterBought1.gameObject.SetActive(false);
            afterBought2.gameObject.SetActive(false);
            afterBought3.gameObject.SetActive(false);
            dashdownbuybtn3.gameObject.SetActive(false);
            dashdownbuybtn4.gameObject.SetActive(true);
            bought.gameObject.SetActive(true);         
        }
        else if (costOfDashDown == 2 && dashbdownkontrol.kontroldash == -3 && !boughtDashDown)
        {
            bought.gameObject.SetActive(false);
            notenough.gameObject.SetActive(true);

            afterBought1.gameObject.SetActive(false);
            afterBought2.gameObject.SetActive(false);
            afterBought3.gameObject.SetActive(false);
        }
    }

}
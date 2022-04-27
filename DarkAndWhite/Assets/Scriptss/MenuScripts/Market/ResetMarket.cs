using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetMarket : MonoBehaviour
{
    public BarController kontrol;

    public PlayerMovement player;
    public MarketMenuMoney para;
    /*
    public GameObject speedbar0;
    public GameObject speedbar1;
    public GameObject speedbar2;
    public GameObject speedbar3;
    public GameObject speedbare1;
    public GameObject speedbare2;
    public GameObject speedbare3;
    public GameObject jumpbar0;
    public GameObject jumpbar1;
    public GameObject jumpbar2;
    public GameObject jumpbar3;
    public GameObject jumpbare1;
    public GameObject jumpbare2;
    public GameObject jumpbare3;
    public GameObject dashupbar0;
    public GameObject dashupbar1;
    public GameObject dashupbar2;
    public GameObject dashupbar3;
    public GameObject dashupbare1;
    public GameObject dashupbare2;
    public GameObject dashupbare3;
    public GameObject dashdownbar0;
    public GameObject dashdownbar1;
    public GameObject dashdownbar2;
    public GameObject dashdownbar3;
    public GameObject dashdownbare1;
    public GameObject dashdownbare2;
    public GameObject dashdownbare3;
    */

    public GameObject spdbtn1;
    public GameObject spdbtn2;
    public GameObject spdbtn3;
    public GameObject spdbtn4;
    public GameObject jumpbtn1;
    public GameObject jumpbtn2;
    public GameObject jumpbtn3;
    public GameObject jumpbtn4;
    public GameObject dashupbtn1;
    public GameObject dashupbtn2;
    public GameObject dashupbtn3;
    public GameObject dashupbtn4;
    public GameObject dashdownbtn1;
    public GameObject dashdownbtn2;
    public GameObject dashdownbtn3;
    public GameObject dashdownbtn4;

    public GameObject afterbought;

    public Text notenough;
    public Text Reset;
    public int fiyat1 = 1;
    

    public void resetafterbought()
    {
        if (para.moneyb >= 1)
        {
            para.moneyb = PlayerPrefs.GetInt("HighScore");
            para.moneyb = 1000000;
            PlayerPrefs.SetInt("HighScore", para.moneyb);

            PlayerPrefs.SetInt("firstTime", 0);
            PlayerPrefs.SetInt("kontrolSpeed", 0);
            PlayerPrefs.SetInt("kontrolDash", 0);
            PlayerPrefs.SetInt("CostOfSpeed", 0);
            PlayerPrefs.SetInt("CostOfJump", 0);
            PlayerPrefs.SetInt("CostOfDashUp", 0);
            PlayerPrefs.SetInt("CostOfDashDown",0);

            /*
            speedbar0.gameObject.SetActive(true);
            speedbar1.gameObject.SetActive(false);
            speedbar2.gameObject.SetActive(false);
            speedbar3.gameObject.SetActive(false);
            speedbare1.gameObject.SetActive(false);
            speedbare2.gameObject.SetActive(false);
            speedbare3.gameObject.SetActive(false);
            jumpbar0.gameObject.SetActive(true);
            jumpbar1.gameObject.SetActive(false);
            jumpbar2.gameObject.SetActive(false);
            jumpbar3.gameObject.SetActive(false);
            jumpbare1.gameObject.SetActive(false);
            jumpbare2.gameObject.SetActive(false);
            jumpbare3.gameObject.SetActive(false);
            dashupbar0.gameObject.SetActive(true);
            dashupbar1.gameObject.SetActive(false);
            dashupbar2.gameObject.SetActive(false);
            dashupbar3.gameObject.SetActive(false);
            dashupbare1.gameObject.SetActive(false);
            dashupbare2.gameObject.SetActive(false);
            dashupbare3.gameObject.SetActive(false);
            dashdownbar0.gameObject.SetActive(true);
            dashdownbar1.gameObject.SetActive(false);
            dashdownbar2.gameObject.SetActive(false);
            dashdownbar3.gameObject.SetActive(false);
            dashdownbare1.gameObject.SetActive(false);
            dashdownbare2.gameObject.SetActive(false);
            dashdownbare3.gameObject.SetActive(false);
            */


            spdbtn1.gameObject.SetActive(true);
            spdbtn2.gameObject.SetActive(false);
            spdbtn3.gameObject.SetActive(false);
            spdbtn4.gameObject.SetActive(false);
            jumpbtn1.gameObject.SetActive(true);
            jumpbtn2.gameObject.SetActive(false);
            jumpbtn3.gameObject.SetActive(false);
            jumpbtn4.gameObject.SetActive(false);
            dashupbtn1.gameObject.SetActive(true);
            dashupbtn2.gameObject.SetActive(false);
            dashupbtn3.gameObject.SetActive(false);
            dashupbtn4.gameObject.SetActive(false);
            dashdownbtn1.gameObject.SetActive(true);
            dashdownbtn2.gameObject.SetActive(false);
            dashdownbtn3.gameObject.SetActive(false);
            dashdownbtn4.gameObject.SetActive(false);
            afterbought.gameObject.SetActive(false);
            Reset.gameObject.SetActive(true);
        }
        else
        {
            Reset.gameObject.SetActive(false);
            notenough.gameObject.SetActive(true);
        }

    }

  

}
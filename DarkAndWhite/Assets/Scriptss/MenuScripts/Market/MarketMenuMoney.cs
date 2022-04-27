using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarketMenuMoney : MonoBehaviour
{
    public int moneyb;
    public Text money;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        moneyb = PlayerPrefs.GetInt("HighScore");
        money.text = "Money : " + moneyb;
    }
}

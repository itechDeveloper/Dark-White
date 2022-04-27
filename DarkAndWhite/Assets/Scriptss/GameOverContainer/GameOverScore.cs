using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScore : MonoBehaviour
{
    public SkorCalculator last;
    public TimeScore gecenzaman;
    public GoldScore altin;
    public Text sonskor;
    
    void Start()
    {
        sonskor = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        sonskor.text = "Score : "  +altin.goldscore+ " * 10  + " + " Passed Time = "+ last.lastscore;
        
                
    }
}

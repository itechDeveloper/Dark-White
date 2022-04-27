using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SkorCalculator : MonoBehaviour
{
    public int lastscore;
    public GoldScore sonaltin;
    public TimeScore sonzaman;
    public Tgecis tKontrol;

    public int HighScore;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lastscore = sonaltin.goldscore * 10 + sonzaman.secondtext;
        HighScore = PlayerPrefs.GetInt("HighScore");
        tKontrol.kontrol = PlayerPrefs.GetInt("Tutorial");

        if (lastscore > HighScore && tKontrol.kontrol != 0)
        {
            PlayerPrefs.SetInt("HighScore", lastscore);
        }

    }
}

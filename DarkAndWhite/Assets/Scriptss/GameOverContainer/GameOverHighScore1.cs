using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverHighScore1 : MonoBehaviour
{
    public SkorCalculator lasthighscore;
    public Text highscore;

    public void Start()
    {
        highscore = GetComponent<Text>();
    }

    public void Update()
    {
        highscore.text = "HighScore : " + lasthighscore.HighScore; 
    }
}

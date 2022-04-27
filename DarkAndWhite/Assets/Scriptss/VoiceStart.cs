using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceStart : MonoBehaviour
{
    private void Start()
    {
        if(PlayerPrefs.GetInt("ilkSes") == 0)
        {
            PlayerPrefs.SetInt("SesKontrol", 1);
            PlayerPrefs.SetInt("ilkSes", 1);
        }      
    }  
}

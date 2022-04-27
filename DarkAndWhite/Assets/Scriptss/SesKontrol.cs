using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesKontrol : MonoBehaviour
{
    public GameObject sesAc;
    public GameObject sesKapa;

    void Update()
    {
        if (PlayerPrefs.GetInt("SesKontrol")==1)
        {
            AudioListener.pause = false;
            if (sesAc != null && sesKapa != null) 
            {
                sesAc.gameObject.SetActive(false);
                sesKapa.gameObject.SetActive(true);
            }
        }
        else
        {
            AudioListener.pause = true;
            if (sesAc != null && sesKapa != null)
            {
                sesAc.gameObject.SetActive(true);
                sesKapa.gameObject.SetActive(false);
            }
        }
    }

    public void SesAc()
    {
        PlayerPrefs.SetInt("SesKontrol", 1);
    }

    public void SesKapat()
    {
        PlayerPrefs.SetInt("SesKontrol", 0);
    }
}

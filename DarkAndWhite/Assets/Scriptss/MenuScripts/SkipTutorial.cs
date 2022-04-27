using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipTutorial : MonoBehaviour
{

    public Tgecis tkontrol;
    // Start is called before the first frame update
    public void skiptutorial()
    {
        
            tkontrol.kontrol = 1;
            PlayerPrefs.SetInt("Tutorial", tkontrol.kontrol);
            SceneManager.LoadScene("Menu");
        
    }
}

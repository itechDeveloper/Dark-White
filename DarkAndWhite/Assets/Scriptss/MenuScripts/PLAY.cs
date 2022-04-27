using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLAY : MonoBehaviour
{
    float kontrol;
    public void PlayGame()
    {
        kontrol = PlayerPrefs.GetInt("Tutorial");
        if (kontrol == 0)
        {  
            SceneManager.LoadScene("Tutorial");
            Time.timeScale = 1f;
        }

        else if(kontrol == 1)
        {
            SceneManager.LoadScene("GameScene");
            Time.timeScale = 1f;
        }        
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("QUİT");
    }

}

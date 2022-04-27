using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    public NoBackGround noBackGround;
    public Transform clockHandTransform;
    public float clockSpeed;
    bool clockSpeedAplied;
    public Image image;
    public bool white;

    GameObject[] whitePlatforms;
    GameObject[] blackPlatforms;

    public Health health;
    public PauseMenu pauseMenu;

    public static Clock instance;

    public bool activeNoBg;
    public bool warningNoBg;

    float timeCalculater;
    float timeCounter;
    public AudioSource geriSayim;
    bool played;

    float seconds;
    float angle;
    private void Start()
    {
        clockHandTransform.eulerAngles = new Vector3(0, 0, 0);
    }

    private void Update()
    {
        if (PlayerPrefs.GetInt("Tutorial") == 1)
        {
            if (clockSpeed < 36f)
            {
                clockSpeed += (Time.deltaTime / 10f);
            }
        }
        BackGroundColor();
        PlatformColor();
    }

    void BackGroundColor()
    {
       
        seconds = 180 / clockSpeed;
        angle = (180 / seconds) * 3;

        if (health.health > 0 && !pauseMenu.pause) {
            timeCalculater += Time.deltaTime;
            clockHandTransform.eulerAngles = new Vector3(0, 0, -timeCalculater * clockSpeed);
        }

        if ((clockHandTransform.rotation.eulerAngles.z % 180) <= angle && !played)
        {
            geriSayim.Play();
            played = true;
        }

        if ((clockHandTransform.rotation.eulerAngles.z % 180) > angle)
        {
            played = false;
        }   

        if ((clockHandTransform.rotation.eulerAngles.z % 360) < 180)
        {
            image.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            white = true;
        }
        else
        {
            image.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
            white = false;
        }
    }

    internal void PlatformColor()
    {
        
        whitePlatforms = GameObject.FindGameObjectsWithTag("WhitePlatform");
        blackPlatforms = GameObject.FindGameObjectsWithTag("BlackPlatform");

        //  if(arkaplan.specialplatform == true)
        //  {
        //      foreach (GameObject p in whitePlatforms)
        //      {
        //          p.GetComponent<Collider2D>().enabled = true;
        //      }
        //      foreach (GameObject p in blackPlatforms)
        //      {
        //          p.GetComponent<Collider2D>().enabled = true;
        //      }
        //  }
        //
        //  else
        if (noBackGround.specialplatform)
        {
            foreach(GameObject p in whitePlatforms) {
                p.GetComponent<Collider2D>().enabled = true;
            }
            foreach (GameObject p in blackPlatforms)
            {
                p.GetComponent<Collider2D>().enabled = true;
            }
        }
        else if (white)
        {             
            foreach (GameObject p in whitePlatforms)
            {
                p.GetComponent<Collider2D>().enabled = true;
            }
            foreach(GameObject p in blackPlatforms)
            {
                p.GetComponent<Collider2D>().enabled = false;
            }
        }

        else if (!white)
        {
            foreach (GameObject p in whitePlatforms)
            {
                p.GetComponent<BoxCollider2D>().enabled = false;
            }
            foreach (GameObject p in blackPlatforms)
            {
                p.GetComponent<BoxCollider2D>().enabled = true;
            }
        }
    }
}

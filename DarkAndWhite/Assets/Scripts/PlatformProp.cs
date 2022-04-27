using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformProp : MonoBehaviour
{
    public float speed;
    public NoBackGround noBackGround;
    public string platformColor;

    public bool BHTriggeredWhite;
    public bool BHTriggeredBlack;
    public BoxCollider2D box2D;
    GameObject[] whitePlatforms;
    GameObject[] blackPlatforms;
    GameObject firstWhite;
    GameObject firstBlack;
    public GameObject BlackHole;

    public BHTMove bhtMove;

    public GameObject triggeredWhitePlatform;
    public GameObject triggeredBlackPlatform;

    public Sprite activeSprite, diactiveSprite;

    public Clock clock;

    void Update()
    {
        if (PlayerPrefs.GetInt("Tutorial") == 1)
        {
            if (speed <= 5)
            {
                speed += Time.deltaTime / 90;
            }
        }

        BHTriggerMovement();

        if (transform.position.x < -20 && transform.position.x > -30)
        {
            Destroy(gameObject);
        }
        if (transform.position.x < 30f)
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }

        clock.GetComponent<Clock>();

        SpriteActivation();
    }
    void SpriteActivation()
    {
        if (clock.white)
        {
            if (platformColor == "White")
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = activeSprite;
                gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
            }
            
            if (platformColor == "Black")
            {
                if (clock.activeNoBg && !clock.warningNoBg)
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = activeSprite;
                    gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f);
                }else if (clock.warningNoBg)
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = diactiveSprite;
                    gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
                }
                else if (!clock.activeNoBg)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = diactiveSprite;
                    gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f);
                }              
            }
        }
        else if (!clock.white)
        {
            if (platformColor == "White")
            {
                if (clock.activeNoBg && !clock.warningNoBg)
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = activeSprite;
                    gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f);
                }
                else if (clock.warningNoBg)
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = diactiveSprite;
                    gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
                }
                else if(!clock.activeNoBg)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = diactiveSprite;
                    gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f);
                }
            }
            if (platformColor == "Black")
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = activeSprite;
                gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);

            }
        }
    }

    void BHTriggerMovement()
    {
        if (BHTriggeredWhite)
        {           
            FindFirstPlatform();
            bhtMove.platformColor = "White";
            Instantiate(triggeredWhitePlatform, firstWhite.transform.position, Quaternion.identity);     
            BHTriggeredWhite = false;
            Destroy(firstWhite);      
        }

        if (BHTriggeredBlack)
        {
            FindFirstPlatform();
            bhtMove.platformColor = "Black";
            Instantiate(triggeredBlackPlatform, firstBlack.transform.position, Quaternion.identity);
            BHTriggeredBlack = false;
            Destroy(firstBlack);       
        }
    }

    void FindFirstPlatform()
    {
        whitePlatforms = GameObject.FindGameObjectsWithTag("WhitePlatform");
        blackPlatforms = GameObject.FindGameObjectsWithTag("BlackPlatform");
        for (int i = 0; i < whitePlatforms.Length; i++)
        {
            if (firstWhite == null)
            {
                firstWhite = whitePlatforms[i];
            }else if (whitePlatforms[i].transform.position.x < firstWhite.transform.position.x)
            {
                firstWhite = whitePlatforms[i];
            }
        }

        for (int i = 0; i < blackPlatforms.Length; i++)
        {
            if (firstBlack == null)
            {
                firstBlack = blackPlatforms[i];
            }
            else if (blackPlatforms[i].transform.position.x < firstBlack.transform.position.x)
            {
                firstBlack = blackPlatforms[i];
            }
        }
    }
}

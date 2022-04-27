using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetTiming : MonoBehaviour
{
    public bool sayma;

    public GameObject coinDetectorObj;
    public Health health;
    // Start is called before the first frame update
    void Start()
    {
        coinDetectorObj = GameObject.FindGameObjectWithTag("CoinDedector");
        coinDetectorObj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (sayma == true)
        {
            if (health.health > 0)
            {
                StartCoroutine(ActivateCoin());
            }
        }
    }

    IEnumerator ActivateCoin()
    {
        coinDetectorObj.SetActive(true);
        yield return new WaitForSeconds(5f);
        sayma = false;
        if (GameObject.Find("CoinDedector") != null)
        {
            coinDetectorObj.SetActive(false);
        }
    }
}

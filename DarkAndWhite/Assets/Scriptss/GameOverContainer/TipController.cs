using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipController : MonoBehaviour
{
    public bool gameovertip;
    public GameObject tip1;
    public GameObject tip2;
    public GameObject tip3;
    public GameObject tip4;
    public GameObject tip5;
    public GameObject tip6;
    public int random;


    void Start()
    {
        random = Random.Range(1, 7);
    
    }

    // Update is called once per frame
    void Update()
    {
        if (gameovertip)
        {
            if (random == 1)
            {
                tip1.gameObject.SetActive(true);
                tip2.gameObject.SetActive(false);
                tip3.gameObject.SetActive(false);
                tip4.gameObject.SetActive(false);
                tip5.gameObject.SetActive(false);
                tip6.gameObject.SetActive(false);
            }
            else if (random == 2)
            {
                tip1.gameObject.SetActive(false);
                tip2.gameObject.SetActive(true);
                tip3.gameObject.SetActive(false);
                tip4.gameObject.SetActive(false);
                tip5.gameObject.SetActive(false);
                tip6.gameObject.SetActive(false);
            }
            else if (random == 3)
            {
                tip1.gameObject.SetActive(false);
                tip2.gameObject.SetActive(false);
                tip3.gameObject.SetActive(true);
                tip4.gameObject.SetActive(false);
                tip5.gameObject.SetActive(false);
                tip6.gameObject.SetActive(false);
            }
            else if (random == 4)
            {
                tip1.gameObject.SetActive(false);
                tip2.gameObject.SetActive(false);
                tip3.gameObject.SetActive(false);
                tip4.gameObject.SetActive(true);
                tip5.gameObject.SetActive(false);
                tip6.gameObject.SetActive(false);
            }
            else if (random == 5)
            {
                tip1.gameObject.SetActive(false);
                tip2.gameObject.SetActive(false);
                tip3.gameObject.SetActive(false);
                tip4.gameObject.SetActive(false);
                tip5.gameObject.SetActive(true);
                tip6.gameObject.SetActive(false);
            }
            else if (random == 6)
            {
                tip1.gameObject.SetActive(false);
                tip2.gameObject.SetActive(false);
                tip3.gameObject.SetActive(false);
                tip4.gameObject.SetActive(false);
                tip5.gameObject.SetActive(false);
                tip6.gameObject.SetActive(true);
            }
        }
       


    }
}

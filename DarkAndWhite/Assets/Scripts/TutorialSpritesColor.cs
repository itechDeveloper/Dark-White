using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialSpritesColor : MonoBehaviour
{
    public Clock clock;
    
    void Update()
    {
        if (clock.white)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 1);
        }

        if (!clock.white)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        }
    }
}

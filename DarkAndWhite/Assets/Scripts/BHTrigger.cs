using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BHTrigger : MonoBehaviour
{
    public PlatformProp platformProp;
    public PlatformProp platformPropMiddle;
   // private void OnCollisionEnter2D(Collision2D other)
   // {
   //     
   //     if (other.gameObject.CompareTag("WhitePlatform") || other.gameObject.CompareTag("BlackPlatform"))
   //     {
   //         platformProp.BHTriggered = true;
   //     }
   // }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("BHTriggerWhite"))
        {
            platformProp.BHTriggeredWhite = true;
        }else if (collision.CompareTag("BHTriggerWhiteMiddle"))
        {
            platformPropMiddle.BHTriggeredWhite = true;
        }

        if (collision.CompareTag("BHTriggerBlack"))
        {
            platformProp.BHTriggeredBlack = true;
        }else if (collision.CompareTag("BHTriggerBlackMiddle"))
        {
            platformPropMiddle.BHTriggeredBlack = true;
        }

    }
}

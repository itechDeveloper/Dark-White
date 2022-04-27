using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuKiller : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        
            Destroy(gameObject);

       
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGems : MonoBehaviour
{
    void Update()
    {
        if(transform.position.y < -10f && transform.position.y >-20f)
        {
            Destroy(gameObject);
        }
    }
}

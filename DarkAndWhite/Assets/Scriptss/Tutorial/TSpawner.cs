using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TSpawner : MonoBehaviour
{
    
    [SerializeField] Transform spawnpoint;
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.position = spawnpoint.position;
    }

}



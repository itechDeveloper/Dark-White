using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemies;
    public Transform[] spawnpoints;

    private int rand;
    private int randPosition;

    public float startTimeBtwSpawns;
    private float timeBtwSpawns;
    // Start is called before the first frame update
    private void Start()
    {
        timeBtwSpawns = startTimeBtwSpawns;
    }

    // Update is called once per frame
    private void Update()
    {
        if (timeBtwSpawns <= 0)
        {
            rand = Random.Range(0, enemies.Length);
            randPosition = Random.Range(0, spawnpoints.Length);
            Instantiate(enemies[rand], spawnpoints[randPosition].transform.position, Quaternion.identity);
            timeBtwSpawns = startTimeBtwSpawns;

        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }
}

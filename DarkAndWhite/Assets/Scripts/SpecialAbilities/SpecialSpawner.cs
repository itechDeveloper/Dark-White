using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialSpawner : MonoBehaviour
{
    float spawnStartTime;
    bool canSpawn;
    float chanceOfSpawning;

    float spawnedTime;
    float startSpawnedTime;

    public GameObject noBackcGround;
    public GameObject magnet;
    public GameObject barrier;

    int whichSpawning;

    public Health health;

    void Start()
    {
        startSpawnedTime = 10f;
        chanceOfSpawning = 51f;
        whichSpawning = Random.Range(1, 9);
    }

    void Update()
    {
        if (health.health > 0)
        {
            spawnStartTime += Time.deltaTime;
            if (spawnStartTime >= 10f)
            {
                canSpawn = true;
            }

            if (spawnedTime >= 0f)
            {
                spawnedTime -= Time.deltaTime;
            }
            else
            {
                if (canSpawn) { chanceOfSpawning = Random.Range(0f, 100f);}
                spawnedTime = startSpawnedTime;
            }

            if (chanceOfSpawning <= 50f && canSpawn && whichSpawning <= 3)
            {
                Instantiate(noBackcGround, new Vector2(15f, 0f), Quaternion.identity);
                chanceOfSpawning = 51f;
                whichSpawning = Random.Range(4, 9);
            }
            else if (chanceOfSpawning <= 50f && canSpawn && whichSpawning <= 6)
            {
                Instantiate(barrier, new Vector2(15f, 0f), Quaternion.identity);
                chanceOfSpawning = 51f;
                whichSpawning = Random.Range(1, 9);
            }
            if (chanceOfSpawning <= 50f && canSpawn && whichSpawning <= 8)
            {
                Instantiate(magnet, new Vector2(15f, 0f), Quaternion.identity);
                chanceOfSpawning = 51f;
                whichSpawning = Random.Range(1, 7);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldSpawner : MonoBehaviour
{
    float spawnStartTime;
    bool canSpawn;
    float chanceOfSpawning;

    float spawnedTime;
    float startSpawnedTime;

    public GameObject gold;
    public GameObject spawnPlace1;
    public GameObject spawnPlace2;
    public GameObject spawnPlace3;

    public int spawnedPointNumber;

    bool spawnPointDedected;

    Vector2 whereToSpawn;
    float randomSpawnPlace;

    public Health health;
    void Start()
    {
        chanceOfSpawning = 51f;
        startSpawnedTime = 3f;
        randomSpawnPlace = Random.Range(0, 3);
        if (randomSpawnPlace <= 1)
        {
            whereToSpawn.y = spawnPlace1.transform.position.y;
            spawnedPointNumber = 1;
        }else if (randomSpawnPlace <= 2)
        {
            whereToSpawn.y = spawnPlace2.transform.position.y;
            spawnedPointNumber = 2;
        }
        else
        {
            whereToSpawn.y = spawnPlace3.transform.position.y;
            spawnedPointNumber = 3;
        }

        whereToSpawn.x = 25f;
    }

    // Update is called once per frame
    void Update()
    {
        if (health.health > 0)
        {
            if (!spawnPointDedected)
            {
                if (randomSpawnPlace <= 1)
                {
                    whereToSpawn.y = spawnPlace1.transform.position.y;
                }
                else if (randomSpawnPlace <= 2)
                {
                    whereToSpawn.y = spawnPlace2.transform.position.y;
                }
                else
                {
                    whereToSpawn.y = spawnPlace3.transform.position.y;
                }

                spawnPointDedected = true;
            }

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
                if (canSpawn) { chanceOfSpawning = Random.Range(0f, 100f); }
                spawnedTime = startSpawnedTime;
            }

            if (chanceOfSpawning <= 50f && canSpawn)
            {
                Instantiate(gold, whereToSpawn, Quaternion.identity);
                chanceOfSpawning = 51f;
                randomSpawnPlace = Random.Range(1, 4);
                spawnPointDedected = false;
            }
        }
    }
}

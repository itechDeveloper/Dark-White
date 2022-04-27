using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformWhite;
    public GameObject platformBlack;
    public GameObject platformMiddleWhite;
    public GameObject platformMiddleBlack;
    public GameObject platformSmallWhite;
    public GameObject platformSmallBlack;
    float chancing;

    public GameObject SpawnPoint1, SpawnPoint2, SpawnPoint3, SpawnPoint4, SpawnPoint5, SpawnPoint6, SpawnPoint7;
    int spawnPointChance;
    bool blackUp;
    bool spawned;

    Vector2 whereToSpawn;
    Vector2 whereToSpawn2;
    Vector2 whereToSpawnBlack;
    Vector2 whereToSpawnBlack2;
    public float spawnRate;
    public float nextSpawn;

    public Health health;

    float chanceOfSpawning;

    float timer;
    float platformTimer;
    float secondPlatformTimer;
    public float startSecondPlatformTimer;
    bool canSpawnSecondPlatform;

    public float differenceFirstValueX;
    public float differenceFirstValueY;
    public float differenceSecondValueX;
    public float differenceSecondValueY;

    private void Start()
    {
        chanceOfSpawning = 0f;
        spawnPointChance = Random.Range(3, 6);
        chancing = 0;
    }

    void Update()
    {
        timer += Time.deltaTime;
        platformTimer += Time.deltaTime; 
        //1
        if (spawnPointChance == 1)
        {
            whereToSpawn = SpawnPoint1.transform.position;
            whereToSpawnBlack = SpawnPoint2.transform.position;
            int chance = Random.Range(1,3);
            if (chance == 1)
            {
                whereToSpawn2 = SpawnPoint1.transform.position;
                whereToSpawnBlack2 = SpawnPoint2.transform.position;
                spawnPointChance = Random.Range(1,3);
            }
            else
            {
                whereToSpawn2 = SpawnPoint2.transform.position;
                int chanceOfBlack = Random.Range(1,3);
                if (chanceOfBlack == 1)
                {
                    whereToSpawnBlack2 = SpawnPoint1.transform.position;
                    blackUp = true;
                }
                else
                {
                    whereToSpawnBlack2 = SpawnPoint3.transform.position;
                }
                spawnPointChance = Random.Range(1, 4);
            }
            spawned = true;
        }
        //2
        else if (spawnPointChance == 2 && !spawned)
        {
            whereToSpawn = SpawnPoint2.transform.position;
            if (blackUp)
            {
                whereToSpawnBlack = SpawnPoint1.transform.position;
            }
            else
            {
                whereToSpawnBlack = SpawnPoint3.transform.position;
            }

            int chance = Random.Range(1, 4);
            if (chance == 1)
            {
                whereToSpawn2 = SpawnPoint1.transform.position;
                whereToSpawnBlack2 = SpawnPoint2.transform.position;
                blackUp = false;
                spawnPointChance = Random.Range(1, 3);
            }
            else if(chance == 2)
            {
                whereToSpawn2 = SpawnPoint2.transform.position;
                if (blackUp)
                {
                    whereToSpawnBlack2 = SpawnPoint1.transform.position;
                }
                else
                {
                    whereToSpawnBlack2 = SpawnPoint3.transform.position;
                }
                spawnPointChance = Random.Range(1, 4);
            }
            else
            {
                whereToSpawn2 = SpawnPoint3.transform.position;
                if (blackUp)
                {
                    whereToSpawnBlack2 = SpawnPoint2.transform.position;
                }
                else
                {
                    int chanceOfBlack = Random.Range(1, 3);
                    if (chanceOfBlack == 1)
                    {
                        whereToSpawnBlack2 = SpawnPoint2.transform.position;
                        blackUp = true;
                    }
                    else
                    {
                        whereToSpawnBlack2 = SpawnPoint4.transform.position;
                    }
                }
                spawnPointChance = Random.Range(2, 5);
            }
            spawned = true;
        }
        //3
        else if (spawnPointChance == 3 && !spawned)
        {
            whereToSpawn = SpawnPoint3.transform.position;
            if (blackUp)
            {
                whereToSpawnBlack = SpawnPoint2.transform.position;
            }
            else
            {
                whereToSpawnBlack = SpawnPoint4.transform.position;
            }

            int chance = Random.Range(1, 4);
            if (chance == 1)
            {
                whereToSpawn2 = SpawnPoint2.transform.position;
                if (blackUp)
                {
                    int chanceOfBlack = Random.Range(1, 3);
                    if (chanceOfBlack == 1)
                    {
                        whereToSpawnBlack2 = SpawnPoint1.transform.position;
                    }
                    else
                    {
                        whereToSpawnBlack2 = SpawnPoint3.transform.position;
                        blackUp = false;
                    }
                }
                else
                {
                    whereToSpawnBlack2 = SpawnPoint3.transform.position;
                }
                spawnPointChance = Random.Range(1, 4);
            }
            else if (chance == 2)
            {
                whereToSpawn2 = SpawnPoint3.transform.position;
                if (blackUp)
                {
                    whereToSpawnBlack2 = SpawnPoint2.transform.position;
                }
                else
                {
                    whereToSpawnBlack2 = SpawnPoint4.transform.position;
                }
                spawnPointChance = Random.Range(2, 5);
            }
            else
            {
                whereToSpawn2 = SpawnPoint4.transform.position;
                if (blackUp)
                {
                    whereToSpawnBlack2 = SpawnPoint3.transform.position;
                }
                else
                {
                    int chanceOfBlack = Random.Range(1, 3);
                    if (chanceOfBlack == 1)
                    {
                        whereToSpawnBlack2 = SpawnPoint3.transform.position;
                        blackUp = true;
                    }
                    else
                    {
                        whereToSpawnBlack2 = SpawnPoint5.transform.position;
                    }
                }
                spawnPointChance = Random.Range(3, 6);
            }
            spawned = true;
        }
        //4
        else if (spawnPointChance == 4 && !spawned)
        {
            whereToSpawn = SpawnPoint4.transform.position;
            if (blackUp)
            {
                whereToSpawnBlack = SpawnPoint3.transform.position;
            }
            else
            {
                whereToSpawnBlack = SpawnPoint5.transform.position;
            }

            int chance = Random.Range(1, 4);
            if (chance == 1)
            {
                whereToSpawn2 = SpawnPoint3.transform.position;
                if (blackUp)
                {
                    int chanceOfBlack = Random.Range(1, 3);
                    if (chanceOfBlack == 1)
                    {
                        whereToSpawnBlack2 = SpawnPoint2.transform.position;
                    }
                    else
                    {
                        whereToSpawnBlack2 = SpawnPoint4.transform.position;
                        blackUp = false;
                    }
                }
                else
                {
                    whereToSpawnBlack2 = SpawnPoint4.transform.position;
                }
                spawnPointChance = Random.Range(2, 5);
            }
            else if (chance == 2)
            {
                whereToSpawn2 = SpawnPoint4.transform.position;
                if (blackUp)
                {
                    whereToSpawnBlack2 = SpawnPoint3.transform.position;
                }
                else
                {
                    whereToSpawnBlack2 = SpawnPoint5.transform.position;
                }
                spawnPointChance = Random.Range(3, 6);
            }
            else
            {
                whereToSpawn2 = SpawnPoint5.transform.position;
                if (blackUp)
                {
                    whereToSpawnBlack2 = SpawnPoint4.transform.position;
                }
                else
                {
                    int chanceOfBlack = Random.Range(1, 3);
                    if (chanceOfBlack == 1)
                    {
                        whereToSpawnBlack2 = SpawnPoint4.transform.position;
                        blackUp = true;
                    }
                    else
                    {
                        whereToSpawnBlack2 = SpawnPoint6.transform.position;
                    }
                }
                spawnPointChance = Random.Range(4, 7);
            }
            spawned = true;
        }
        //5
        else if (spawnPointChance == 5 && !spawned)
        {
            whereToSpawn = SpawnPoint5.transform.position;
            if (blackUp)
            {
                whereToSpawnBlack = SpawnPoint4.transform.position;
            }
            else
            {
                whereToSpawnBlack = SpawnPoint6.transform.position;
            }

            int chance = Random.Range(1, 4);
            if (chance == 1)
            {
                whereToSpawn2 = SpawnPoint4.transform.position;
                if (blackUp)
                {
                    int chanceOfBlack = Random.Range(1, 3);
                    if (chanceOfBlack == 1)
                    {
                        whereToSpawnBlack2 = SpawnPoint3.transform.position;
                    }
                    else
                    {
                        whereToSpawnBlack2 = SpawnPoint5.transform.position;
                        blackUp = false;
                    }
                }
                else
                {
                    whereToSpawnBlack2 = SpawnPoint5.transform.position;
                }
                spawnPointChance = Random.Range(3, 6);
            }
            else if (chance == 2)
            {
                whereToSpawn2 = SpawnPoint5.transform.position;
                if (blackUp)
                {
                    whereToSpawnBlack2 = SpawnPoint4.transform.position;
                }
                else
                {
                    whereToSpawnBlack2 = SpawnPoint6.transform.position;
                }
                spawnPointChance = Random.Range(4, 7);
            }
            else
            {
                whereToSpawn2 = SpawnPoint6.transform.position;
                if (blackUp)
                {
                    whereToSpawnBlack2 = SpawnPoint5.transform.position;
                }
                else
                {
                    int chanceOfBlack = Random.Range(1, 3);
                    if (chanceOfBlack == 1)
                    {
                        whereToSpawnBlack2 = SpawnPoint5.transform.position;
                        blackUp = true;
                    }
                    else
                    {
                        whereToSpawnBlack2 = SpawnPoint7.transform.position;
                    }
                }
                spawnPointChance = Random.Range(5, 8);
            }
            spawned = true;
        }
        //6
        else if (spawnPointChance == 6 && !spawned)
        {
            whereToSpawn = SpawnPoint6.transform.position;
            if (blackUp)
            {
                whereToSpawnBlack = SpawnPoint5.transform.position;
            }
            else
            {
                whereToSpawnBlack = SpawnPoint7.transform.position;
            }

            int chance = Random.Range(1, 4);
            if (chance == 1)
            {
                whereToSpawn2 = SpawnPoint5.transform.position;
                if (blackUp)
                {
                    int chanceOfBlack = Random.Range(1, 3);
                    if (chanceOfBlack == 1)
                    {
                        whereToSpawnBlack2 = SpawnPoint4.transform.position;
                    }
                    else
                    {
                        whereToSpawnBlack2 = SpawnPoint6.transform.position;
                        blackUp = false;
                    }
                }
                else
                {
                    whereToSpawnBlack2 = SpawnPoint6.transform.position;
                }
                spawnPointChance = Random.Range(4, 7);

            }
            else if (chance == 2)
            {
                whereToSpawn2 = SpawnPoint6.transform.position;
                if (blackUp)
                {
                    whereToSpawnBlack2 = SpawnPoint5.transform.position;
                }
                else
                {
                    whereToSpawnBlack2 = SpawnPoint7.transform.position;
                }
                spawnPointChance = Random.Range(5, 8);
            }
            else
            {
                whereToSpawn2 = SpawnPoint7.transform.position;
                whereToSpawnBlack2 = SpawnPoint6.transform.position;
                blackUp = true;
                spawnPointChance = Random.Range(6, 8);
            }
            spawned = true;
        }
        //7
        else if (spawnPointChance == 7 && !spawned)
        {
            whereToSpawn = SpawnPoint7.transform.position;
            whereToSpawnBlack = SpawnPoint6.transform.position;
            int chance = Random.Range(1, 3);
            if (chance == 1)
            {
                whereToSpawn2 = SpawnPoint6.transform.position;
                int chanceOfBlack = Random.Range(1, 3);
                if (chanceOfBlack == 1)
                {
                    whereToSpawnBlack2 = SpawnPoint5.transform.position;
                }
                else
                {
                    whereToSpawnBlack2 = SpawnPoint7.transform.position;
                    blackUp = false;
                }
                spawnPointChance = Random.Range(5, 8);
            }
            else
            {
                whereToSpawn2 = SpawnPoint7.transform.position;
                whereToSpawnBlack2 = SpawnPoint6.transform.position;
                spawnPointChance = Random.Range(6, 8);
            }
            spawned = true;
        }
        ///////

        if (platformTimer <= 240f)
        {
            chanceOfSpawning += Time.deltaTime;
        }

        if (timer > nextSpawn && health.health > 0)
        {
            float randomWhiteX1 = Random.Range(differenceFirstValueX,differenceSecondValueX);
            float randomWhiteY1 = Random.Range(differenceFirstValueY, differenceSecondValueY);
            whereToSpawn.x += randomWhiteX1;
            whereToSpawn.y += randomWhiteY1;
            float randomWhiteX2 = Random.Range(differenceFirstValueX, differenceSecondValueX);
            float randomWhiteY2 = Random.Range(differenceFirstValueY, differenceSecondValueY);
            whereToSpawn2.x += randomWhiteX2;
            whereToSpawn2.y += randomWhiteY2;
            float randomBlackX1 = Random.Range(differenceFirstValueX, differenceSecondValueX);
            float randomBlackY1 = Random.Range(differenceFirstValueY, differenceSecondValueY);
            whereToSpawnBlack.x += randomBlackX1;
            whereToSpawnBlack.y += randomBlackY1;
            float randomBlackX2 = Random.Range(differenceFirstValueX, differenceSecondValueX);
            float randomBlackY2 = Random.Range(differenceFirstValueY, differenceSecondValueY);
            whereToSpawnBlack2.x += randomBlackX2;
            whereToSpawnBlack2.y += randomBlackY2;

            nextSpawn = timer + spawnRate;
            chancing = Random.Range(0, 120) + chanceOfSpawning;

            if (chancing <= 240f) {
                Instantiate(platformWhite, whereToSpawn, Quaternion.identity);
                Instantiate(platformBlack, whereToSpawnBlack, Quaternion.identity);
            }
            else{
                Instantiate(platformMiddleWhite, whereToSpawn, Quaternion.identity);
                Instantiate(platformMiddleBlack, whereToSpawnBlack, Quaternion.identity);             
            }

            secondPlatformTimer = startSecondPlatformTimer;
            canSpawnSecondPlatform = true;
            spawned = false;
        }

        if (canSpawnSecondPlatform)
        {
            chancing = Random.Range(0, 120) + chanceOfSpawning;

            if (secondPlatformTimer >= 0f)
            {
                secondPlatformTimer -= Time.deltaTime;
            }
            else
            {
                if (chancing <= 240f)
                {
                    Instantiate(platformWhite, whereToSpawn2, Quaternion.identity);
                    Instantiate(platformBlack, whereToSpawnBlack2, Quaternion.identity);
                }
                else
                {
                    Instantiate(platformMiddleWhite, whereToSpawn2, Quaternion.identity);
                    Instantiate(platformMiddleBlack, whereToSpawnBlack2, Quaternion.identity);
                }
                canSpawnSecondPlatform = false;
            }
     
        }
    }
}

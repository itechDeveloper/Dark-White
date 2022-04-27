using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    Vector2 whereToSpawn;

    //DroppingObstacle
    public GameObject droppingObstacle;
    float randomXdroppingObstacle;
    private float spawnRateDropping;
    public float nextSpawn;
    public float spawnRateFirstValueOfDropping;
    public float spawnRateSecondValueOfDropping;
    public float randomXfirstValueOfDropping;
    public float randomXsecondValueOfDropping;
    float droppingTimeCounter;

    //Meteor
    public GameObject meteor;
    public int chanceOfSpawningMeteor;
    float randomXmeteor;
    private float spawnRateMeteor;
    public float nextSpawnMeteor;
    public float spawnRateFirstValueOfMeteor;
    public float spawnRateSecondValueOfMeteor;
    public float randomXfirstValueOfMeteor;
    public float randomXsecondValueOfMeteor;
    float meteorTimeCounter;

    //BlackHoleThrowingObstacle
    public GameObject blackHoleThrowingObstacle;
    public int chanceOfSpawningBalckHoleThrowing;
    private float spawnRateBlackHoleThrowing;
    public float nextSpawnBlackHoleThrowing;
    public float spawnRateFirstValueOfBlackHoleThrowing;
    public float spawnRateSecondValueOfBlackHoleThrowing;
    public Transform blackHole;
    float blackHoleThrowingTimeCounter;

    //SeperatedObstacle
    public GameObject seperatedObstacle;
    public int chanceOfSpawningSeperated;
    private float spawnRateSeperated;
    public float nextSpawnSeperated;
    public float spawnRateFirstValuOfSeperated;
    public float spawnRateSecondValueOfSeperated;
    float seperatedTimeCounter;

    //FollowingObstacle
    public GameObject followingObstacle;
    public int chanceOfSpawningFollowing;
    private float spawnRateFollowing;
    public float nextSpawnFollowing;
    public float spawnRateFirstValueOfFollowing;
    public float spawnRateSecondValueOfFollowing;
    public float randomYfirstValueOfFollowing;
    public float randomYsecondValueOfFollowing;
    float followingTimeCounter;

    //PendulumObstacle
    public GameObject pendulumObstacle;
    public int chanceOfSpawningPendulum;
    private float spawnRatePendulum;
    public float nextSpawnPendulum;
    public float spawnRateFirstValueOfPendulum;
    public float spawnRateSecondValueOfPendulum;
    public float randomYfirstValueOfPendulum;
    public float randomYsecondValueOfPendulum;
    float pendulumTimeCounter;

    //GroundThrowingObstacle
    public GameObject groundThrowingObstacle;
    public int chanceOfSpawningGroundThrowing;
    private float spawnRateGroundThrowing;
    public float nextSpawnGroundThrowing;
    public float spawnRateFirstValueOfGroundThrowing;
    public float spawnRateSecondValueOfGroundThrowing;
    public float randomYfirstValueOfGroundThrowing;
    public float randomYsecondValueOfGroundThrowing;
    float groundTimeCounter;

    //geçici skor
    public SkorCalculator skorCalculator;

    public Health health;

    public float spawnTiming;
    public float startSpawnTiming = 0f;
    bool canSpawn;

    void Start()
    {
        spawnTiming = startSpawnTiming;
        spawnRateDropping = Random.Range(spawnRateFirstValueOfDropping, spawnRateSecondValueOfDropping);

        droppingTimeCounter = 0f;
        blackHoleThrowingTimeCounter = 0f;
        seperatedTimeCounter = 0f;
        followingTimeCounter = 0f;
        pendulumTimeCounter = 0f;
        groundTimeCounter = 0f;
        meteorTimeCounter = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        droppingTimeCounter += Time.deltaTime;
        blackHoleThrowingTimeCounter += Time.deltaTime;
        seperatedTimeCounter += Time.deltaTime;
        followingTimeCounter += Time.deltaTime;
        pendulumTimeCounter += Time.deltaTime;
        groundTimeCounter += Time.deltaTime;
        meteorTimeCounter += Time.deltaTime;

        if (spawnTiming > 10)
        {
            canSpawn = false;
            spawnTiming -= Time.deltaTime;
        }
        else
        {
            canSpawn = true;
        }

        if (health.health > 0) {
            DroppingObstacleSpawn();
            BlackHoleThrowingObstacleSpawn();
            SeperatedObstacleSpawn();
            FollowingObstacleSpawn();
            PendulumObstacleSpawn();
            GroundThrowingObstacleSpawn();
            MeteorSpawn();
        }
    }

    void DroppingObstacleSpawn()
    {        
        if (droppingTimeCounter> nextSpawn && canSpawn)
        {
            spawnRateDropping = Random.Range(spawnRateFirstValueOfDropping, spawnRateSecondValueOfDropping);
            nextSpawn = droppingTimeCounter + spawnRateDropping;
            randomXdroppingObstacle = Random.Range(randomXfirstValueOfDropping, randomXsecondValueOfDropping);
            whereToSpawn = new Vector2(randomXdroppingObstacle, 8f);
            Instantiate(droppingObstacle, whereToSpawn, Quaternion.identity);
        }
    }


    void MeteorSpawn()
    {
        if (meteorTimeCounter > nextSpawnMeteor && canSpawn)
        {
            float randomSpawningNumber = Random.Range(0, 100);
            randomSpawningNumber -= skorCalculator.lastscore / 40;
            if (randomSpawningNumber <= chanceOfSpawningMeteor)
            {
                spawnRateMeteor = Random.Range(spawnRateFirstValueOfMeteor, spawnRateSecondValueOfMeteor);
                nextSpawnMeteor = meteorTimeCounter + spawnRateMeteor;
                randomXmeteor = Random.Range(randomXfirstValueOfMeteor, randomXsecondValueOfMeteor);
                whereToSpawn = new Vector2(randomXmeteor, 8f);
                Instantiate(meteor, whereToSpawn, Quaternion.identity);
            }
            else if (randomSpawningNumber > chanceOfSpawningMeteor)
            {
                spawnRateMeteor = Random.Range(spawnRateFirstValueOfMeteor, spawnRateSecondValueOfMeteor);
                nextSpawnMeteor = meteorTimeCounter + spawnRateMeteor;
            }
        }
    }

    void BlackHoleThrowingObstacleSpawn()
    {
        if (blackHoleThrowingTimeCounter > nextSpawnBlackHoleThrowing && canSpawn)
        {
            float randomSpawningNumber = Random.Range(0, 100);
            randomSpawningNumber -= skorCalculator.lastscore / 30;
            if (randomSpawningNumber <= chanceOfSpawningBalckHoleThrowing)
            {
                spawnRateBlackHoleThrowing = Random.Range(spawnRateFirstValueOfBlackHoleThrowing, spawnRateSecondValueOfBlackHoleThrowing);
                nextSpawnBlackHoleThrowing = blackHoleThrowingTimeCounter + spawnRateBlackHoleThrowing;
                whereToSpawn = blackHole.position;
                Instantiate(blackHoleThrowingObstacle, whereToSpawn, Quaternion.identity);
            }else if (randomSpawningNumber > chanceOfSpawningBalckHoleThrowing)
            {
                spawnRateBlackHoleThrowing = Random.Range(spawnRateFirstValueOfBlackHoleThrowing, spawnRateSecondValueOfBlackHoleThrowing);
                nextSpawnBlackHoleThrowing = blackHoleThrowingTimeCounter + spawnRateBlackHoleThrowing;
            }        
        }
    }

    void SeperatedObstacleSpawn()
    {
        if (seperatedTimeCounter > nextSpawnSeperated && canSpawn)
        {
            float randomSpawningNumber = Random.Range(0, 100);
            randomSpawningNumber -= skorCalculator.lastscore / 30;
            if (randomSpawningNumber <= chanceOfSpawningSeperated)
            {
                spawnRateSeperated = Random.Range(spawnRateFirstValuOfSeperated, spawnRateSecondValueOfSeperated);
                nextSpawnSeperated = seperatedTimeCounter + spawnRateSeperated;
                float randomY = Random.Range(2.5f,-1.5f);
                whereToSpawn = new Vector2(13f, randomY);
                Instantiate(seperatedObstacle, whereToSpawn, Quaternion.identity);
            }else if (randomSpawningNumber > chanceOfSpawningSeperated)
            {
                spawnRateSeperated = Random.Range(spawnRateFirstValuOfSeperated, spawnRateSecondValueOfSeperated);
                nextSpawnSeperated = seperatedTimeCounter + spawnRateSeperated;
            }
        }
    }

    void FollowingObstacleSpawn()
    {

        if (followingTimeCounter > nextSpawnFollowing && canSpawn)
        {
            float randomSpawningNumber = Random.Range(0, 100);
            randomSpawningNumber -= skorCalculator.lastscore / 30;
            if (randomSpawningNumber <= chanceOfSpawningFollowing)
            {
                spawnRateFollowing = Random.Range(spawnRateFirstValueOfFollowing, spawnRateSecondValueOfFollowing);
                nextSpawnFollowing = followingTimeCounter + spawnRateFollowing;
                float randomYfollowingObstacle = Random.Range(randomYfirstValueOfFollowing, randomYsecondValueOfFollowing);
                whereToSpawn = new Vector2(12f, randomYfollowingObstacle);
                Instantiate(followingObstacle, whereToSpawn, Quaternion.identity);
            }else if (randomSpawningNumber > chanceOfSpawningFollowing)
            {
                spawnRateFollowing = Random.Range(spawnRateFirstValueOfFollowing, spawnRateSecondValueOfFollowing);
                nextSpawnFollowing = followingTimeCounter + spawnRateFollowing;
            }
        }
    }

    void PendulumObstacleSpawn()
    {
        if (pendulumTimeCounter > nextSpawnPendulum && canSpawn)
        {
            float randomSpawningNumber = Random.Range(0, 100);
            randomSpawningNumber -= skorCalculator.lastscore / 30;
            if (randomSpawningNumber <= chanceOfSpawningPendulum)
            {
                spawnRatePendulum = Random.Range(spawnRateFirstValueOfPendulum, spawnRateSecondValueOfPendulum);
                nextSpawnPendulum = pendulumTimeCounter + spawnRatePendulum;
                float randomYpendulumObstacle = Random.Range(randomYfirstValueOfPendulum, randomYsecondValueOfPendulum);
                whereToSpawn = new Vector2(12f, randomYpendulumObstacle);
                Instantiate(pendulumObstacle, whereToSpawn, Quaternion.identity);
            }else if (randomSpawningNumber > chanceOfSpawningPendulum)
            {
                spawnRatePendulum = Random.Range(spawnRateFirstValueOfPendulum, spawnRateSecondValueOfPendulum);
                nextSpawnPendulum = pendulumTimeCounter + spawnRatePendulum;
            }
        }
    }

    void GroundThrowingObstacleSpawn()
    {
        if (groundTimeCounter > nextSpawnGroundThrowing && canSpawn)
        {
            float randomSpawningNumber = Random.Range(0, 100);
            randomSpawningNumber -= skorCalculator.lastscore / 30;
            if (randomSpawningNumber <= chanceOfSpawningGroundThrowing)
            {
                spawnRateGroundThrowing = Random.Range(spawnRateFirstValueOfGroundThrowing, spawnRateSecondValueOfGroundThrowing);
                nextSpawnGroundThrowing = groundTimeCounter + spawnRateGroundThrowing;
                float randomXgroundThrowingObstacle = Random.Range(randomYfirstValueOfGroundThrowing, randomYsecondValueOfGroundThrowing);
                whereToSpawn = new Vector2(randomXgroundThrowingObstacle, Random.Range(-4f, -6f));
                Instantiate(groundThrowingObstacle, whereToSpawn, Quaternion.identity);
            }
            else if (randomSpawningNumber > chanceOfSpawningGroundThrowing)
            {
                spawnRateGroundThrowing = Random.Range(spawnRateFirstValueOfGroundThrowing, spawnRateSecondValueOfGroundThrowing);
                nextSpawnGroundThrowing = groundTimeCounter + spawnRateGroundThrowing;
            }
        }
    }
}

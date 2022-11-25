using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;
    // These variables are for the times of the beginning of spawning the ball and the interval it takes to spawn another one.
    private float startDelay = 2.0f;
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        SpawnRandomBall();
    }

    // Spawn random ball at random x position at top of play area
    // This code block will spawn randomly of the prefab colored balls.
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        int BallNo = Random.Range(0, ballPrefabs.Length);

        // instantiate ball at random spawn location, at random times.
        Instantiate(ballPrefabs[BallNo], spawnPos, ballPrefabs[BallNo].transform.rotation);
        Invoke("SpawnRandomBall", Random.Range(startDelay, spawnInterval));


    }

}

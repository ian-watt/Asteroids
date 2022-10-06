using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroids : MonoBehaviour
{
    public GameObject[] asteroidPrefabs;
    private float startDelay = 3;
    private float spawnInterval;
    public float asteroidVelocity;
    private float spawnIntervalRangeL = 2.5f;
    private float spawnIntervalRangeR = 3f;



    void Start()
    {
        spawnInterval = Random.Range(spawnIntervalRangeL, spawnIntervalRangeR);
        asteroidVelocity = Random.Range(5, 10);
        InvokeRepeating("SpawnRandomAsteroid", startDelay, spawnInterval);
        InvokeRepeating("Difficulty", 5f, 5);


    }

    void Update()
    {
        
    }
    void SpawnRandomAsteroid()
    {
        float radius = new Vector3(38, 0, 22).magnitude;
        Vector3 forward = new Vector3(0, 0, 1);
        forward = Quaternion.AngleAxis(Random.Range(0, 360), Vector3.up) * forward;
        forward = forward.normalized * radius;

        Vector3 spawnPos1 = forward;
        int asteroidIndex1 = Random.Range(0, asteroidPrefabs.Length);
        GameObject newAsteroid1 = Instantiate(asteroidPrefabs[asteroidIndex1], spawnPos1, Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)));
        Rigidbody rb1 = newAsteroid1.GetComponent<Rigidbody>();
        forward = new Vector3(0, 0, 1);
        forward = Quaternion.AngleAxis(Random.Range(0, 360), Vector3.up) * forward;
        forward = forward.normalized * Random.Range(0, radius);
        rb1.velocity = (forward - spawnPos1).normalized * asteroidVelocity;
    }
    public void Difficulty()
    {
        {
            CancelInvoke();
            InvokeRepeating("SpawnRandomAsteroid", 0, Random.Range(spawnIntervalRangeL - 1, spawnIntervalRangeR -1));

        }
    }
}
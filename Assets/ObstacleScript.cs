using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ObstacleScript : MonoBehaviour//obstacleSpawnerCode
{
    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;
    public float MinSpawnRate;
    public float MaxSpawnRate;
    private float spawnRate = 3;
    private float timer = 0;
    
    System.Random randomObstacle = new System.Random();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] obstacles = new GameObject[3] { obstacle1, obstacle2, obstacle3 };
        int index = randomObstacle.Next(0, 3);
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Instantiate(obstacles[index],transform.position, transform.rotation);            
            timer = 0;
            spawnRate = UnityEngine.Random.Range(MinSpawnRate, MaxSpawnRate);
        }
            
    }
}

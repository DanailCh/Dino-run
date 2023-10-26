using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawnerScript : MonoBehaviour
{
    public GameObject cloud;
    public float MinSpawnRate;
    public float MaxSpawnRate;
    private float spawnRate;
    private float timer = 0;

    System.Random randomObstacle = new System.Random();
    // Start is called before the first frame update
    void Start()
    {
        spawnRate = UnityEngine.Random.Range(MinSpawnRate, MaxSpawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Instantiate(cloud, transform.position, transform.rotation);
            timer = 0;
            spawnRate = UnityEngine.Random.Range(MinSpawnRate, MaxSpawnRate);
        }

    }
}

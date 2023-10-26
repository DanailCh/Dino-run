using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawnerScript : MonoBehaviour
{
    public GameObject floor;
    public float spawnRate = 5;
    private float timer = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(floor, transform.position, transform.rotation);
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
           Instantiate(floor, transform.position, transform.rotation);
           timer = 0;

       }
            
    }
    
}

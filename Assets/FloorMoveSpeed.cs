using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMoveSpeed : MonoBehaviour
{
    public float moveSpeed = 15;
    private float deadZone = -100;
    private bool isStopped = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isStopped)
        {
            transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
            if (transform.position.x < deadZone)
            {
                Destroy(gameObject);
            }
        }        
    }
    public void Stop()
    {
        isStopped = true;
    }
}

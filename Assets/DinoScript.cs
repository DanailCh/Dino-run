using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoScript : MonoBehaviour//charchter jump
{
    public Rigidbody2D myRigidbody;
    public GameObject logicScript;
    public float jumpStrength;
    public bool isAlive = true;
    public bool isJumping = false;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&isAlive&&!isJumping)
        {
            myRigidbody.velocity = Vector2.up * jumpStrength;
            isJumping = true;
        }        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logicScript.GetComponent<LogicScript>().GameOver();
            isAlive = false;
        }
        if (collision.gameObject.layer==6)
        {
            isJumping = false;
        }
    }
}

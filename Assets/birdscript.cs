using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;


public class birdscript : MonoBehaviour
{
    public LogicScript logic;
    public Rigidbody2D myRigidbody;
    public float flapstrength;
    public bool birdIsAlive = true;
    public GameObject bullet;

    public float spawnRate = 3;

    private float timer = 4;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) == true && birdIsAlive == true)
        {
            myRigidbody.velocity = Vector2.up * flapstrength;
        }





        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }







        if (Input.GetKeyDown(KeyCode.Mouse0) == true && timer > spawnRate)
        {
            Instantiate(bullet, new Vector3(transform.position.x +3, transform.position.y, 0), transform.rotation);
            timer = 0; 
        }



        if (Input.GetKeyDown(KeyCode.D) == true && timer > spawnRate)
        {
            myRigidbody.velocity = Vector2.right * flapstrength;
        }


        if (Input.GetKeyDown(KeyCode.A) == true && timer > spawnRate)
        {
            myRigidbody.velocity = Vector2.left * flapstrength;
        }


    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;

    }
}
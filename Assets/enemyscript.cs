using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour
{
    private bool enemyalive = true;
    public int direction = 0;
    private float spawnRate = 4;
    private float timer = 0;
    public GameObject bullet;


    public float movespeed = 3;
    // Start is called before the first frame update
    void Start()
    {

        direction = Random.Range(1, 2);
    }


// Update is called once per frame








void Update()
{



    //movement start
    if (direction == 2)
    {
        transform.position = transform.position + (Vector3.down * movespeed) * Time.deltaTime;
        if (transform.position.y < -9.5)
        {
            direction = 1;
        }


    }

    if (direction == 1)
    {
        transform.position = transform.position + (Vector3.up * movespeed) * Time.deltaTime;
        if (transform.position.y > 9.5)
        {
            direction = 2;
        }

    }
    //movement end






    if (enemyalive == false)
    {
        Destroy(gameObject);
    }



    if (timer < spawnRate)
    {
        timer = timer + Time.deltaTime;
    }



    if (true && timer > spawnRate)
    {
        Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
        timer = 0;
    }






}
private void OnCollisionEnter2D(Collision2D collision)
{

    enemyalive = false;

}

     





        
}
   

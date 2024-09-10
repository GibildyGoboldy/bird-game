using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawn : MonoBehaviour
{
   
    public LogicScript logic;
    public GameObject enemy;
    public int alive = 1;
    public float spawnRate = 4;
    public float timer = 0;
    public float yoffset = 5;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate && alive == 1)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnenemy();
            timer = 0;
        }



        void spawnenemy()
        {
            float lowestpoint = transform.position.y - yoffset;
            float highestpoint = transform.position.y + yoffset;

            Instantiate(enemy, new Vector3(transform.position.x, Random.Range(lowestpoint, highestpoint), 0), transform.rotation);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner2 : MonoBehaviour
{

    public GameObject logic;
    public GameObject enemy;


    public float spawnRate;
    public float timer = 0;
    public float yoffset = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
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

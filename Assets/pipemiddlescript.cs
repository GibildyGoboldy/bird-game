using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class pipemiddlescript : MonoBehaviour
{


    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.addScore(1);
    }
}



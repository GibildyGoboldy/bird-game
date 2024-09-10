using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmovement : MonoBehaviour
{
    public float deadZone2 = -20;
    public float deadZone = 45;
    public float moveSpeed = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.right * moveSpeed) * Time.deltaTime;
        if (transform.position.x > deadZone)
        {
            Debug.Log("bullet deleted");
            Destroy(gameObject);
        }
        if (transform.position.x < deadZone2)
        {
            Debug.Log("bullet deleted");
            Destroy(gameObject);
        }
    }
}

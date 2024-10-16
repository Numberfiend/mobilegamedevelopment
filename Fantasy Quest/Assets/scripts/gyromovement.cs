using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gyromovement : MonoBehaviour
{
    float dirx;
    float movespeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dirx = Input.acceleration.x * movespeed * Time.deltaTime;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -7.5f, 7.5f), transform.position.y);

    }
}

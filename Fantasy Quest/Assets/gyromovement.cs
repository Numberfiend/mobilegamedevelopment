using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gyromovement : MonoBehaviour
{
    public float movespeed = 5.0f;
    Vector2 movevector;
    // Start is called before the first frame update
    void Start()
    {
       Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        //Input.gyro.enabled = true;
        Debug.Log(Input.acceleration);
        if (Input.acceleration.x >= 0.4f)
        {
            Vector2 move = new Vector2(1, 0);
            transform.Translate(move * movespeed * Time.deltaTime);
        }

        if (Input.acceleration.x <= -0.4f)
        {
            Vector2 move = new Vector2(-1, 0);
            transform.Translate(move * movespeed * Time.deltaTime);
        }

        if (Input.acceleration.y >= 0.4f)
        {
            Vector2 move = new Vector2(0, 1);
            transform.Translate(move * movespeed * Time.deltaTime);
        }
        
        if (Input.acceleration.y <= -0.4f)
        {
            Vector2 move = new Vector2(0, -1);
            transform.Translate(move * movespeed * Time.deltaTime);
        }
        
    }
}

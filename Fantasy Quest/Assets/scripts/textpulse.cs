using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textpulse : MonoBehaviour
{
    public TextMeshProUGUI text;
    public bool pulsing = true;

    public float pulse_speed = 3.0f;
    public float normal_size = 1.0f;
    public float min_size = 0.5f;   
    public float max_size = 2.0f;
   

    void Start()
    {
     
    }

  
    void Update()
    {
        if (pulsing)
        {
            normal_size += pulse_speed * Time.deltaTime;
            if (normal_size >= max_size)
            {
                normal_size = max_size;
                pulsing = false;
            }
        }
        else
        {
            normal_size -= pulse_speed * Time.deltaTime;
            if (normal_size <= min_size)
            {
                normal_size = min_size;
                pulsing = true;
            }
        }

        text.transform.localScale = Vector3.one * normal_size;
    }
}

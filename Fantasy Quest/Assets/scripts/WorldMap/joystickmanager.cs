using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joystickmanager : MonoBehaviour
{
    public GameObject joysticks;
    public string bruh;

    public void Start()
    {
        bruh = PlayerPrefs.GetString("control");
        if (bruh == "joysticks")
        {
            joysticks.SetActive(true);
        }
        else
        {
            joysticks.SetActive(false);
        }
    }
    public void joystickconfirm()
    {
        bruh = PlayerPrefs.GetString("control");
        if (bruh == "joysticks" && joysticks.activeSelf == false)
        {
            joysticks.SetActive(true);
        }
        else
        {
            
        }
        
    }

    public void joystickdisable()
    {
        bruh = PlayerPrefs.GetString("control");
        if (bruh == "joysticks" && joysticks.activeSelf == true)
        {
            joysticks.SetActive(false);
        }
        else
        {
            
        }
    }
}

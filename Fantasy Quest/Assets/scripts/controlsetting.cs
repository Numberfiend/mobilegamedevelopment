using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlsetting : MonoBehaviour
{
    public string bruh;
    public void joystickselect()
    {
        PlayerPrefs.SetString("control", "joysticks");
    }
    public void gyroselect()
    {
        PlayerPrefs.SetString("control", "gyro");
    }
    public void touchselect()
    {
        PlayerPrefs.SetString("control", "touch");
    }
}

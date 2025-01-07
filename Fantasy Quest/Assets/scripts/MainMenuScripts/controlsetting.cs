using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CandyCoded.HapticFeedback;
public class controlsetting : MonoBehaviour
{
    public string bruh;
    public void joystickselect()
    {
        if (PlayerPrefs.GetInt("haptics") == 1)
        {
            HapticFeedback.LightFeedback();
        }
        PlayerPrefs.SetString("control", "joysticks");
    }
    public void gyroselect()
    {
        if (PlayerPrefs.GetInt("haptics") == 1)
        {
            HapticFeedback.LightFeedback();
        }
        PlayerPrefs.SetString("control", "gyro");
    }
    public void touchselect()
    {
        if (PlayerPrefs.GetInt("haptics") == 1)
        {
            HapticFeedback.LightFeedback();
        }
        PlayerPrefs.SetString("control", "touch");
    }

    
    
}

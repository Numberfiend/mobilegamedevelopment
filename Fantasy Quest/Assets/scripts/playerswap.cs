using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class playerswap : MonoBehaviour
{
    public GameObject joystickplayer;
    public GameObject gyroplayer;
    public GameObject touchplayer;
    private string controlcheck;
    // Start is called before the first frame update
    void Start()
    {
        controlcheck = PlayerPrefs.GetString("control");

        if (controlcheck == "joysticks")
        {
            joystickplayer.SetActive(true);
            gyroplayer.SetActive(false);
            touchplayer.SetActive(false);
        }
        else if (controlcheck == "gyro")
        {
            joystickplayer.SetActive(false);
            gyroplayer.SetActive(true);
            touchplayer.SetActive(false);
        }
        else if (controlcheck == "touch")
        {
            joystickplayer.SetActive(false);
            gyroplayer.SetActive(false);
            touchplayer.SetActive(true);
        }
        else
        {
            joystickplayer.SetActive(true);
            gyroplayer.SetActive(false);
            touchplayer.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        activeswap();
    }

    private void activeswap()
    {
        controlcheck = PlayerPrefs.GetString("control");

        if (controlcheck == "joysticks")
        {
            joystickplayer.SetActive(true);
            gyroplayer.SetActive(false);
            touchplayer.SetActive(false);
        }
        else if (controlcheck == "gyro")
        {
            joystickplayer.SetActive(false);
            gyroplayer.SetActive(true);
            touchplayer.SetActive(false);
        }
        else if (controlcheck == "touch")
        {
            joystickplayer.SetActive(false);
            gyroplayer.SetActive(false);
            touchplayer.SetActive(true);
        }
        else
        {
            joystickplayer.SetActive(true);
            gyroplayer.SetActive(false);
            touchplayer.SetActive(false);
        }
    }

}


using UnityEngine;

public class playerswap : MonoBehaviour
{
    public GameObject joystickplayer;
    public GameObject gyroplayer;

    private string controlcheck;
    // Start is called before the first frame update
    void Start()
    {
        controlcheck = PlayerPrefs.GetString("control");
        

        if (controlcheck == "joysticks")
        {
            joystickplayer.SetActive(true);
            gyroplayer.SetActive(false);
         
        }
        else if (controlcheck == "gyro")
        {
            joystickplayer.SetActive(false);
            gyroplayer.SetActive(true);
           
        }
        else if (controlcheck == "touch")
        {
            joystickplayer.SetActive(false);
            gyroplayer.SetActive(false);
           
        }
        else
        {
            joystickplayer.SetActive(true);
            gyroplayer.SetActive(false);
       
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
           
        }
        else if (controlcheck == "gyro")
        {
            joystickplayer.SetActive(false);
            gyroplayer.SetActive(true);
          
        }
        else if (controlcheck == "touch")
        {
            joystickplayer.SetActive(false);
            gyroplayer.SetActive(false);
           
        }
        else
        {
            joystickplayer.SetActive(true);
            gyroplayer.SetActive(false);
       
        }
    }

}

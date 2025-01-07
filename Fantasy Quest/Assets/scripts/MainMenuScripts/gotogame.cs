using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using CandyCoded.HapticFeedback;
public class gotogame : MonoBehaviour
{



    void Start()
    {

    }

    void Update()
    {
        
    }

    public void OnFadeComplete()
    {
        if(PlayerPrefs.GetInt("haptics") == 1)
        {
            HapticFeedback.LightFeedback();
        }
        SceneManager.LoadScene("WorldMap");
    }
}


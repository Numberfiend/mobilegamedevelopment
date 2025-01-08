using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CandyCoded.HapticFeedback;
public class hapticcheck : MonoBehaviour
{
   
    public Toggle toggle; 

    private void Start()
    {
       
        if (PlayerPrefs.HasKey("haptics"))
        {
            int savedValue = PlayerPrefs.GetInt("haptics");
            toggle.isOn = savedValue == 1; 
        }
        else
        {
            PlayerPrefs.SetInt("haptics", toggle.isOn ? 1 : 0);
        }

        
        toggle.onValueChanged.AddListener(OnToggleChanged);
    }

    private void OnToggleChanged(bool isOn)
    {
        
        PlayerPrefs.SetInt("haptics", isOn ? 1 : 0);
        PlayerPrefs.Save(); 
        Debug.Log(PlayerPrefs.GetInt("haptics"));
    }
    public void hapticscheck()
    {
        if(PlayerPrefs.GetInt("haptics") == 1)
        {
            Debug.Log("VIBRATEEEEEEE");
            HapticFeedback.MediumFeedback();
        }
    }

    
}

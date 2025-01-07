using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using CandyCoded.HapticFeedback;
public class touchdetection : MonoBehaviour
{
    public Animator animator;
    public int bruh = 0;
    public bool isHaptic;
    void Start()
    {

        PlayerPrefs.SetInt("haptics", 1);
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {

            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                Debug.Log("Touch detected at position: " + touch.position);
                if(bruh == 0)
                {
                   
                    if(PlayerPrefs.GetInt("haptics") == 1)
                    { 
                        Debug.Log("we vibrating");
                        HapticFeedback.LightFeedback();
                    }
                    
                }
                
                animator.SetTrigger("FadeOut");
             
                
            }
        }
    }

    public void OnFadeComplete()
    {
        
   
        SceneManager.LoadScene("MainMenu");
    }
}

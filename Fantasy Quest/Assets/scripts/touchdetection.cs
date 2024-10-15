using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class touchdetection : MonoBehaviour
{
    public Animator animator;
    
    void Start()
    {

    }

    void Update()
    {
        if (Input.touchCount > 0)
        {

            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                Debug.Log("Touch detected at position: " + touch.position);
                
                animator.SetTrigger("FadeOut");
             
                
            }
        }
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

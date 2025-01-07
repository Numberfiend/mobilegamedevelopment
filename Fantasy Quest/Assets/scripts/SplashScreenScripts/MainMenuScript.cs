using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.SceneManagement;
using CandyCoded.HapticFeedback;
using GooglePlayGames.BasicApi;
using GooglePlayGames;
public class SplashScreenScript : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPlay()
    {
        HapticFeedback.LightFeedback();
        animator.SetTrigger("FadeOut");
    }

    public void OnPressAchievement()
    {
        Social.ShowAchievementsUI();
    }

    public void OnFadeComplete()
    {


        SceneManager.LoadScene("MainMenu");
    }
}

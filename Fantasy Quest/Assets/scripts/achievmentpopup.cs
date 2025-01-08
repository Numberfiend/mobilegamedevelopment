using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;
public class achievmentpopup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void displayAchi()
    {
        Debug.Log("yoooooooo");
        if (PlayGamesPlatform.Instance.IsAuthenticated())
        {
            PlayGamesPlatform.Instance.ShowAchievementsUI();
        }
        
    }

    public void unlockAchiev()
    {
        if (PlayGamesPlatform.Instance.IsAuthenticated())
        {

            PlayGamesPlatform.Instance.ReportProgress("CgkI_J-eqbEYEAIQBw", 100f, (bool success) =>
            {
                if(success)
                {

                }
            });
            
        }
    }

    public void incrementAchiev()
    {
        if (PlayGamesPlatform.Instance.IsAuthenticated())
        {
            PlayGamesPlatform.Instance.IncrementAchievement("CgkI_J-eqbEYEAIQCA", 1, (bool success) =>
            {
                if (success)
                {

                }
            });
        }
    }
}


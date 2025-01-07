using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;

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
}

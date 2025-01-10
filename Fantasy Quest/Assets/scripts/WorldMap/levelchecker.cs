using GooglePlayGames;
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelchecker : MonoBehaviour
{
    public GameObject level1Uncompleted;
    public GameObject level2Uncompleted;
    public GameObject level3Uncompleted;
    public GameObject level4Uncompleted;
    public GameObject level1Completed;
    public GameObject level2Completed;
    public GameObject level3Completed;
    public GameObject level4Completed;
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetInt("level1state", 0);
        //PlayerPrefs.SetInt("level2state", 0);
        //PlayerPrefs.SetInt("level3state", 0);
        //PlayerPrefs.SetInt("level4state", 0);
        int level1state = PlayerPrefs.GetInt("level1state");
        int level2state = PlayerPrefs.GetInt("level2state");
        int level3state = PlayerPrefs.GetInt("level3state");
        int level4state = PlayerPrefs.GetInt("level4state");
        Debug.Log(level1state);
        if(level1state == 1)
        {
            level1Uncompleted.SetActive(false);
            level1Completed.SetActive(true);
        }
        if(level2state == 1)
        {
            level2Uncompleted.SetActive(false);
            level2Completed.SetActive(true);
        }
        if(level3state == 1)
        {
            level3Uncompleted.SetActive(false);
            level3Completed.SetActive(true);
        }
        if(level4state == 1)
        {
            level4Uncompleted.SetActive(false);
            level4Completed.SetActive(true);
        }

        if (level1state == 1 || level2state == 1 || level3state == 1 || level4state == 1)
        {
            if (PlayGamesPlatform.Instance.IsAuthenticated())
            {

                PlayGamesPlatform.Instance.ReportProgress("CgkI_J-eqbEYEAIQAQs", 100f, (bool success) =>
                {
                    if (success)
                    {

                    }
                });

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

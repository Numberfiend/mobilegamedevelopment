using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{

    private float countdownTime = 60.0f;
    private float countdownSpeed = 1f;
    public TMP_Text timertext;
    public Slider enemyhealth;
    private float remainingTime;
    // Start is called before the first frame update
    void Start()
    {
       
        remainingTime = countdownTime;
        UpdateTimer();
        StartCoroutine(CountdownCoroutine());
    }

    IEnumerator CountdownCoroutine()
    {
        while(remainingTime > 0)
        {
            yield return new WaitForSeconds(countdownSpeed);
            remainingTime -= countdownSpeed;
            UpdateTimer();
        }
        countdownFinished();
        if(remainingTime <= 0 && enemyhealth.value > 0)
        {
          
            SceneManager.LoadScene("lossscreen");
        }
        
    }

    void UpdateTimer()
    {
        timertext.text = remainingTime.ToString("0");
    }
    void countdownFinished()
    {
        Debug.Log("Finished");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

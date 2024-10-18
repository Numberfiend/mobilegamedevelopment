using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class wincon : MonoBehaviour
{
    public Slider player;
    public Slider enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.value <= 0)
        {
            SceneManager.LoadScene("winscreen");
        }
        else if (enemy.value <= 0)
        {
            SceneManager.LoadScene("lossscreen");
        }
    }
}

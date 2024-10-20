using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;
using CandyCoded.HapticFeedback;
public class startanims : MonoBehaviour
{
    public Slider healthbar;
    public float maxhealth = 100f;
    public float health;
    public Animator playeranim;
    public GameObject fightbutton;
    // Start is called before the first frame update
    void Start()
    {
        health = maxhealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (healthbar.value != health)
        {
            healthbar.value = health;
        }
        string playercheck = PlayerPrefs.GetString("turn");
        while(playercheck == "enemy")
        {
            fightbutton.SetActive(false);
        }
        
    }

    public void attackpress()
    {
        StartCoroutine(AttackCoroutine());
       
    }

    private IEnumerator AttackCoroutine()
    {
        playeranim.SetBool("canattack", true);
        PlayerPrefs.SetString("turn", "enemy");
        yield return new WaitForSeconds(1.833f);
        HapticFeedback.LightFeedback();
        Handheld.Vibrate();
        takedamage();
        playeranim.SetBool("canattack", false);
        
    }

    void takedamage()
    {
        health -= 10;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class turnmanage : MonoBehaviour
{
    public Slider healthbar;
    public float maxhealth = 100f;
    public float health;
    [SerializeField]
    private float lerpspeed = 0.05f;
    public Animator enemyanim;
    // Start is called before the first frame update
    void Start()
    {
        health = maxhealth;
        PlayerPrefs.SetString("turn", "player");   
    }

    
    void Update()
    {
        if (healthbar.value != health)
        {
            healthbar.value = health;
        }
        
        string turncheck2 = PlayerPrefs.GetString("turn");
        if(turncheck2 == "enemy")
        {
            enemyattack();
        }
    }

    void enemyattack()
    {
        string turncheck = PlayerPrefs.GetString("turn");
        if (turncheck == "enemy")
        {
            StartCoroutine(EnemyAttackCoroutine());
            
        }
    }

    private IEnumerator EnemyAttackCoroutine()
    {
        enemyanim.SetBool("enemyattack", true);
        PlayerPrefs.SetString("turn", "player");
        yield return new WaitForSeconds(3.7f);
        takedamage();
        enemyanim.SetBool("enemyattack", false);



    }

    void takedamage()
    {
        health -= 10;
    }
}


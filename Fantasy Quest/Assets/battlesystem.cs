using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using CandyCoded.HapticFeedback;


public class battlesystem : MonoBehaviour
{
    public Animator player;
    public Animator enemy;
    public Slider bosshealth;
    public GameObject attackbutton;
    public GameObject magicbutton;
    public AudioSource slash;
    public AudioSource cast;
    public ParticleSystem particleEffect;
    [SerializeField]
    public int meleedefence = 10;
    public int magicdefence = 10;
    [SerializeField]
    public int rng = 6;
    


    public void melee()
    {
        attackbutton.SetActive(false);
        magicbutton.SetActive(false);
        player.SetBool("isAttacking", true);
        StartCoroutine(attackwait());
        
    }

    public void magic()
    {
        attackbutton.SetActive(false);
        magicbutton.SetActive(false);
        player.SetBool("isCasting", true);
        StartCoroutine(magicwait());
        StartCoroutine(vfxwait());
    }

    IEnumerator attackwait()
    {
        slash.Play();
        yield return new WaitForSeconds(1.833f);
        int randomcheck = rngen();
        if(randomcheck >= rng)
        {
            Critvibrate();
            Debug.Log("CRITCALHITTTTT");
            bosshealth.value -= 20;
        }
        else
        {
            bosshealth.value -= (20 - meleedefence);
        }
        
        player.SetBool("isAttacking", false);
    }
    IEnumerator magicwait()
    {
        cast.Play();
        yield return new WaitForSeconds(4.8f);
        int randomcheck = rngen();
        if(randomcheck >= rng)
        {
            Critvibrate();
            Debug.Log("CRITICALLLL HIT");
            bosshealth.value -= 20;
        }
        else
        {
            bosshealth.value -= (20 - magicdefence);
        }
        
        player.SetBool("isCasting", false);
    }
    IEnumerator vfxwait()
    {
        particleEffect.Play();
        yield return new WaitForSeconds(3.5f);
        particleEffect.Stop();
    }

    int rngen()
    {
        return Random.Range(0, 10);
    }

    void Critvibrate()
    {
        if (PlayerPrefs.GetInt("haptics") == 1)
        {
          
            HapticFeedback.HeavyFeedback();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(bosshealth.value <= 0) 
        {
            SceneManager.LoadScene("winscreen");
        }
    }
}

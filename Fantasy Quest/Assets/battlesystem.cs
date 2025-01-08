using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class battlesystem : MonoBehaviour
{
    public Animator player;
    public Animator enemy;
    public Slider bosshealth;
    public GameObject attackbutton;
    public GameObject magicbutton;
    public ParticleSystem particleEffect;
    [SerializeField]
    public int meleedefence = 5;
    public int magicdefence = 5;
    

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
        yield return new WaitForSeconds(1.833f);
        bosshealth.value -= 10;
        player.SetBool("isAttacking", false);
    }
    IEnumerator magicwait()
    {
        yield return new WaitForSeconds(1.833f);
        bosshealth.value -= 10;
        player.SetBool("isCasting", false);
    }
    IEnumerator vfxwait()
    {
        particleEffect.Play();
        yield return new WaitForSeconds(3.5f);
        particleEffect.Stop();
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
            
            SceneManager.LoadScene("youwin");
        }
    }
}

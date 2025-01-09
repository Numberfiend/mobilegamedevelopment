using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adloader : MonoBehaviour
{

    public InterstitialAd ad;
    
    public static adloader instance { get; private set; }

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        ad.LoadAd();
    }
    void Start()
    {
        StartCoroutine(showing());   
    }

    public IEnumerator showing()
    {
        yield return new WaitForSeconds(5f);
        ad.ShowAd();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

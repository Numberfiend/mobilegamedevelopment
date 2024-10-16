using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
public class canvasswitcher : MonoBehaviour
{
    public GameObject menucanvas;
    public GameObject optioncanvas;
    public bool activemenu = true;
    // This method will switch canvases when called
    public void SwitchCanvas()
    {

        if (activemenu)
        {
            optioncanvas.SetActive(false);
            menucanvas.SetActive(true);
          
        }
        else
        {   
           optioncanvas.SetActive(true);
           menucanvas.SetActive(false);
        }
        
        
    }
    public void switching()
    {
        Debug.Log("clicked options");
    }
}

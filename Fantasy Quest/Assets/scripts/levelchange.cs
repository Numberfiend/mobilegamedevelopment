using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelchange : MonoBehaviour
{
    public void retry()
    {
        SceneManager.LoadScene("RandomBattleMap");
    }

    public void mainmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void worldmap()
    {
        SceneManager.LoadScene("WorldMap");
    }
}

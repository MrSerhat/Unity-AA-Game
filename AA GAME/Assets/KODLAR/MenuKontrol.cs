using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuKontrol : MonoBehaviour
{
     void Start()
    {
        //PlayerPrefs.DeleteAll();
    }
    public void OyunaGit()
    {
        int kayitlilevel = PlayerPrefs.GetInt("Kayit");

        if (kayitlilevel==0)
        {
            SceneManager.LoadScene(kayitlilevel + 1);

        }
        else
        {
            SceneManager.LoadScene(kayitlilevel);
        }

        
        
    }

    public void Cik()
    {
        
        Application.Quit();
    }
}

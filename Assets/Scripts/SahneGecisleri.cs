using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneGecisleri : MonoBehaviour
{    
    public void AnaSayfa()
    {
        SceneManager.LoadScene(0);
    }
    public void Yardim()
    {
        SceneManager.LoadScene(1);
    }
    public void Oyna()
    {
        SceneManager.LoadScene(4);
    }
    public void Cikis()
    {
        Application.Quit();
    }
    public void TekrarOyna()
    {
        SceneManager.LoadScene(4);
        PlayerPrefs.DeleteAll();
    }
}

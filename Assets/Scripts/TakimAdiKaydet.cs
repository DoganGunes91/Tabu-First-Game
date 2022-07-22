using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TakimAdiKaydet : MonoBehaviour
{
    //string takim1ad, takim2ad;
    public InputField takim1ad, takim2ad;
    void Start()
    {
        
    }
    /*public void Takım1()
    {
        takim1ad = PlayerPrefs.GetString("takim1add");
    }
    public void Takım2()
    {
        takim2ad = PlayerPrefs.GetString("takim2add");
    }*/
    public void kaydet()
    {
        PlayerPrefs.SetString("takım1isim", takim1ad.text);
        PlayerPrefs.SetString("takım2isim", takim2ad.text);
        SceneManager.LoadScene(5);
    }
}
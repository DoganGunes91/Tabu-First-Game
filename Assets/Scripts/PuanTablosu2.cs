using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PuanTablosu2 : MonoBehaviour
{
    public Text takimad1, takimad2, takimbilgi;
    void Start()
    {
        takimad1.text = "" + PlayerPrefs.GetString("takım1isim") + ": " + PlayerPrefs.GetInt("takım1puan");
        takimad2.text = "" + PlayerPrefs.GetString("takım2isim") + ": " + PlayerPrefs.GetInt("takım2puan");
        takimbilgi.text = "Sıra " + PlayerPrefs.GetString("takım1isim") + " Takımında";
    }
    public void Takim1Gec()
    {
        SceneManager.LoadScene(5);
    }
}
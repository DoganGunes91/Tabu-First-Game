using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PuanTablosu1 : MonoBehaviour
{
    public Text takimad1, takimad2, takimbilgi;
    void Start()
    {
        takimad1.text = "" + PlayerPrefs.GetString("takım1isim") + ": " + PlayerPrefs.GetInt("takım1puan");
        takimad2.text = "" + PlayerPrefs.GetString("takım2isim") + ": " + PlayerPrefs.GetInt("takım2puan");
        takimbilgi.text = "Sıra " + PlayerPrefs.GetString("takım2isim") + " Takımında";
    }
    public void Takim2Gec()
    {
        SceneManager.LoadScene(7);
    }
}
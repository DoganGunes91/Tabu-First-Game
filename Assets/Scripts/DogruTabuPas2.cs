using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class DogruTabuPas2 : MonoBehaviour
{
    public Button dogru, pas, tabu;
    int pasHakki = 3;
    int puan2 = 0;
    public Text puantext, takimad2;
    public AudioSource dogruses, tabuses, passes;
    void Start()
    {
        takimad2.text = "" + PlayerPrefs.GetString("takým2isim");
        dogruses.Stop();
        tabuses.Stop();
        passes.Stop();
        puan2 = PlayerPrefs.GetInt("takým2puan");
        puantext.text = "Puan: " + PlayerPrefs.GetInt("takým2puan");
    }    
    public void Dogru()
    {
        dogruses.Play();
        puan2++;
        puantext.text = "Puan: " + puan2;
        PlayerPrefs.SetInt("takým2puan", puan2);

        if (puan2 == 25)
        {
            SceneManager.LoadScene(3);
        }
    }
    public void Tabu()
    {
        tabuses.Play();
        puan2--;
        puantext.text = "Puan: " + puan2;
        PlayerPrefs.SetInt("takým2puan", puan2);
    }
    public void Pas()
    {
        passes.Play();
        pasHakki--;
        if (pasHakki == 0)
        {
            pas.interactable = false;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class DogruTabuPas1 : MonoBehaviour
{
    public Button dogru, pas, tabu;
    int pasHakki = 3;
    int puan1 = 0;
    public Text puantext, takimad1;
    public AudioSource dogruses, tabuses, passes;
    void Start()
    {
        takimad1.text = "" + PlayerPrefs.GetString("takým1isim");
        dogruses.Stop();
        tabuses.Stop();
        passes.Stop();
        puan1 = PlayerPrefs.GetInt("takým1puan");
        puantext.text = "Puan: " + PlayerPrefs.GetInt("takým1puan");
    }    
    public void Dogru()
    {
        dogruses.Play();
        puan1++;
        puantext.text = "Puan: " + puan1;
        PlayerPrefs.SetInt("takým1puan", puan1);

        if (puan1 == 25)
        {
            SceneManager.LoadScene(2);
        }
    }
    public void Tabu()
    {
        tabuses.Play();
        puan1--;
        puantext.text = "Puan: " + puan1;
        PlayerPrefs.SetInt("takým1puan", puan1);
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
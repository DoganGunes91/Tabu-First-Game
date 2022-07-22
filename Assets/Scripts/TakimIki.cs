using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakimIki : MonoBehaviour
{
    public Text takimad1, takimad2, kazanan2;
    void Start()
    {
        takimad1.text = "" + PlayerPrefs.GetString("takım1isim") + ": " + PlayerPrefs.GetInt("takım1puan");
        takimad2.text = "" + PlayerPrefs.GetString("takım2isim") + ": " + PlayerPrefs.GetInt("takım2puan");
        kazanan2.text = "" + PlayerPrefs.GetString("takım2isim") + " Kazandı!";
    }
}
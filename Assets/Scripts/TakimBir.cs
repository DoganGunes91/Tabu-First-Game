using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakimBir : MonoBehaviour
{
    public Text takimad1, takimad2, kazanan1;
    void Start()
    {
        takimad1.text = "" + PlayerPrefs.GetString("takım1isim") + ": " + PlayerPrefs.GetInt("takım1puan");
        takimad2.text = "" + PlayerPrefs.GetString("takım2isim") + ": " + PlayerPrefs.GetInt("takım2puan");
        kazanan1.text = "" + PlayerPrefs.GetString("takım1isim") + " Kazandı!";
    }
}
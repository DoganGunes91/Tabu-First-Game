using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GeriSayim2 : MonoBehaviour
{
    public Image timebar;
    int zaman = 60;
    public Text zamantext;
    void Start()
    {
        InvokeRepeating("zamanAzalt", 1, 1);
    }
    void zamanAzalt()
    {
        zaman--;
        zamantext.text = "" + zaman;
        if (zaman == 0)
        {
            SceneManager.LoadScene(8);
        }
    }
    void Update()
    {
        timebar.fillAmount -= 1.0f / 60 * Time.deltaTime;
    }
}
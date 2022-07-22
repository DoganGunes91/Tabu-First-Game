using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OyunEkrani : MonoBehaviour
{
    public Image randomImage;
    
    public List<Sprite> images = new List<Sprite>{};

    void Start()
    {
        int num = Random.Range(0, images.Count);
        randomImage.sprite = images[num];
        images.Remove(randomImage.sprite);
    }
    public void changeImage()
    {
        int num = Random.Range(0, images.Count);
        randomImage.sprite = images[num];
        images.Remove(randomImage.sprite);
    }
}
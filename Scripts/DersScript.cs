using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class DersScript : MonoBehaviour
{

    public Sprite[] barinaklar;
    public SpriteRenderer image;
    public string isim;
    public Button buton;    

    void Start()
    {
        image = GameObject.FindWithTag("image").GetComponent<SpriteRenderer>();
        buton = GameObject.Find("AnaButon").GetComponent<Button>();
        buton.onClick.AddListener(Clicker);
    }

    void Update()
    {
        if (image != null)
        {
            image = GameObject.FindWithTag ("image").GetComponent<SpriteRenderer>();

            isim = image.sprite.name;
        }
    }



    public void Clicker()
    {
        if (isim == "k")
        {
            image.sprite = barinaklar[0];
        }
        if (isim == "i")
        {
            image.sprite = barinaklar[1];
        }
        if(isim == "a")
        {
            image.sprite = barinaklar[2];
        }
    }
}
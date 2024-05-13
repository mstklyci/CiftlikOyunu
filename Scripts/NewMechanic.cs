using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMechanic : MonoBehaviour
{

    public Skor scoreSc;

    private void Start()
    {
        scoreSc = GameObject.Find("i").GetComponent<Skor>();
    }

    public void Bounce()
    {
        GameObject ari = GameObject.FindWithTag("ari");
        if (ari != null && Time.timeScale == 1)
        {
            Rigidbody2D rb = ari.GetComponent<Rigidbody2D>();
            rb.gravityScale = 0f;
            scoreSc.score -= 1;
        }

        GameObject kopek = GameObject.FindWithTag("kopek");
        if (kopek != null && Time.timeScale == 1)
        {
            Rigidbody2D rb = kopek.GetComponent<Rigidbody2D>();
            rb.gravityScale = 0f;
            scoreSc.score -= 1;
        }

        GameObject inek = GameObject.FindWithTag("inek");
        if (inek != null && Time.timeScale == 1)
        {
            Rigidbody2D rb = inek.GetComponent<Rigidbody2D>();
            rb.gravityScale = 0;
            scoreSc.score -= 1;
        }
    }
}
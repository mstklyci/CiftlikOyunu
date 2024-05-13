using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;
public class Skor : MonoBehaviour
{

    public int score;
    public Text ScoreText;
    public GameObject startpanel, gamepanel, gameoverpanel;
    public GameObject playButton;
    void Awake()
    {
        ScoreText = GameObject.Find("Score").GetComponent<Text>();
        score = 0;
    }

    void Start()
    {
        Time.timeScale = 0f;
        playButton.SetActive(true);
    }

    void Update()
    {
        ScoreText.text = "Toplam skor : " + score;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ari" && this.gameObject.GetComponent<SpriteRenderer>().sprite.name == "a")
        {
            score = score + 1;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "kopek" && this.gameObject.GetComponent<SpriteRenderer>().sprite.name == "k")
        {
            score = score + 1;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "inek" && this.gameObject.GetComponent<SpriteRenderer>().sprite.name == "i")
        {
            score = score + 1;
            Destroy(collision.gameObject);
        }
        else
        {
            Destroy(collision.gameObject);
            Time.timeScale = 0f;
            gamepanel.SetActive(false);
            gameoverpanel.SetActive(true);
        }
    }

    public void GameStart()
    {
        startpanel.SetActive(false);   
        gamepanel.SetActive(true);
        playButton.SetActive(false);
        Time.timeScale = 1f;
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(0);
    }
}
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    // Player Jump
    public float jumping = 5f;
    private Rigidbody2D rb;

    // Coloring
    private SpriteRenderer sr;
    private string currentColor;
    public Color[] colors;

    // Text 
    public TMP_Text text;
    public Text score, highScore;
    public int value;
    public int number; // for highscore


    // Game Process
    public GameObject one, two, three;
    public GameObject Panel;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        RandomColor();
        rb.bodyType = RigidbodyType2D.Static; // baþta hareketsiz 
        Panel.SetActive(false);
        highScore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
    }

    void Update()
    {
        text.text = value.ToString();
        // space veya mouse sol týk
        if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
            rb.velocity = Vector2.up  * jumping;
        }
    }

    // trigger Method
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "ColorChanger")
        {
            col.gameObject.transform.position = transform.position + new Vector3(0f, 21.5f, 0f);
            one.transform.position = transform.position + new Vector3(0f, 18f, 0f);
            RandomColor();
           // Destroy(col.gameObject); gerek kalmadý yukarý taþýdýk
            value += 10;
            number += 10;
            score.text = value.ToString();
            if(number > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", number);
                highScore.text = number.ToString();
            }
            return;
        }
        if (col.tag == "one")
        {
            col.gameObject.transform.position = transform.position + new Vector3(0f, 21.5f, 0f);
            two.transform.position = transform.position + new Vector3(0f, 18f, 0f);
            RandomColor();
            // Destroy(col.gameObject); gerek kalmadý yukarý taþýdýk
            value += 10;
            number += 10;
            score.text = value.ToString();
            if (number > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", number);
                highScore.text = number.ToString();
            }
            return;
        }
        if (col.tag == "two")
        {
            col.gameObject.transform.position = transform.position + new Vector3(0f, 21.5f, 0f);
            three.transform.position = transform.position + new Vector3(0f, 18f, 0f);
            RandomColor();
            // Destroy(col.gameObject); gerek kalmadý yukarý taþýdýk
            value += 10;
            number += 10;
            score.text = value.ToString();
            if (number > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", number);
                highScore.text = number.ToString();
            }
            return;
        }
        if (col.tag != currentColor)
        {
            Debug.Log("GameOver");
            Panel.SetActive(true);
            Time.timeScale = 0; // Oyunu durdurur.

           // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Olduðu sahneden yeniden baþlar
        }
    }

    // color method
    private void RandomColor()
    {
        int index = Random.Range(0, colors.Length);

        switch(index)
        {
            case 0:
                currentColor = "Cam";
                sr.color = colors[index];
                break;
            case 1:
                currentColor = "Sari";
                sr.color = colors[index];
                break;
            case 2:
                currentColor = "Pembe";
                sr.color = colors[index];
                break;
            case 3:
                currentColor = "Mor";
                sr.color = colors[index];
                break;
        }
    }
}

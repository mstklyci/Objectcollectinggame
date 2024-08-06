using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    public Text scoreText;
    public int score;
    public GameObject GameOver;

    public Rigidbody2D rb;
    public float oyuncuHizi = 5f;

    private void Start()
    {
        Time.timeScale = 1f;
        rb = GetComponent<Rigidbody2D>();
        GameOver.SetActive(false);
    }

    private void Update()
    {
        scoreText.text = score.ToString();
        rb.velocity = Vector2.right*Input.GetAxis("Horizontal") *oyuncuHizi;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("can"))
        {
            score += 1;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("dusman"))
        {
            Destroy(collision.gameObject);
            Time.timeScale = 0f;
            GameOver.SetActive(true);
        }
    }

    public void ButonFonksiyonu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
}
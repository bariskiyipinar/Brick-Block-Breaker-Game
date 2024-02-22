using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    
    public int horizontaljump,verticaljump;

    public TextMeshProUGUI ScoreText;
    public static int score;

    void Start()
    {
        rb.velocity = new Vector2(Random.Range(-horizontaljump, verticaljump),rb.velocity.y);
        score = 0;
    }

     void Update()
    {
        ScoreText.text = "Score:" + score;
    }

    void OnCollisionEnter2D(Collision2D temas)
    {

        if (temas.gameObject.tag == "Player")
        {
            rb.velocity = new Vector2(rb.velocity.x, verticaljump);
        }

        if(temas.gameObject.tag == "LeftWall")
        {
            rb.velocity = new Vector2(horizontaljump, rb.velocity.y);
        }

        if(temas.gameObject.tag == "RightWall")
        {
            rb.velocity=new Vector2(-horizontaljump, rb.velocity.y);
        }

        if (temas.gameObject.tag == "TopWall")
        {
            rb.velocity=new Vector2(rb.velocity.x, -verticaljump);
        }

        if (temas.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (temas.gameObject.tag == "GreenBlock")
        {
            score++;
        }
    }
}

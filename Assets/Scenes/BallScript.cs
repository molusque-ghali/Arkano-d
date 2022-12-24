using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BallScript : MonoBehaviour
{
    public GameObject racket;
    public GameObject texte;
    public int score = 0;
    public TextMeshProUGUI scoretext;
    public float speed = 100.00f;
    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketWidth)
    {
        return (ballPos.x - racketPos.x) / racketWidth;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "racket")
        {
            float x = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.x);
            Vector2 dir = new Vector2(x, 1).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;
           

        }
    }
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
        texte.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = score.ToString();
       if (gameObject.transform.position.y < racket.transform.position.y)
        {
            texte.SetActive(true);
        }
       
    }
}

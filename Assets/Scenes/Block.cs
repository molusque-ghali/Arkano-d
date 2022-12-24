using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int life = 3;
    public GameObject balle;

  

    // Start is called before the first frame update
    void Start()
    {
        balle = FindObjectOfType<BallScript>().gameObject;  
    }

    // Update is called once per frame
    void Update()
    {

    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        life = life - 1;
        if (life == 0)
        {
            balle.GetComponent<BallScript>().score++;
            Destroy(gameObject);
        }
    }
}

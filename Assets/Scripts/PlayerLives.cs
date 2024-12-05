using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLives : MonoBehaviour
{
    private GameObject heart1;
    private GameObject heart2;
    private GameObject heart3;
    private GameObject heart4;
    private GameObject heart5;
    public int deathCounter;
    public int gameOver;
    // Start is called before the first frame update

    private void Awake()
    {
        heart1 = GameObject.Find("HeartContainer1");
        heart1 = GameObject.Find("HeartContainer2");
        heart1 = GameObject.Find("HeartContainer3");
        heart1 = GameObject.Find("HeartContainer4");
        heart1 = GameObject.Find("HeartContainer5");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.CompareTag("Enemy"))
        {
            deathCounter += 1;
        }

        if (deathCounter == 10)
        {
            Destroy(heart1);
        }

        if (deathCounter == 20)
        {
            Destroy(heart2);
        }

        if (deathCounter == 30)
        {
            Destroy(heart3);
        }

        if (deathCounter == 40)
        {
            Destroy(heart4);
        }

        if (deathCounter == 50)
        {
            Destroy(heart5);
            //Instantiate(gameOver,respawner,Quaternion.identity);
        }



        /*if (collision.collider.gameObject.tag == "Enemy")
        {
            Destroy(collision.collider.gameObject);
            lives -= 1;
            if (lives <= 0)
            {
                Destroy(gameObject);
            }
        }*/
    }
}
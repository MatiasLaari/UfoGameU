using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ufo2 : MonoBehaviour
{
    public GameObject explosionPrefab;
    private PointManager pointManager; // ScoreMagerin koodia

    public int deathCounter;// ufo2 osuma laskuri
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Enemy2"))
        {
            deathCounter += 1;

        }

        if (deathCounter == 2)
        {
            GameObject newExplosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(newExplosion, 3f);
            Destroy(collision.gameObject);
            pointManager.UpdateScore(5);// t‰m‰ lis‰‰ ScoreManageriiin pisteen
            Destroy(gameObject);
        }
    }
}

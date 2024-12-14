using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullets : MonoBehaviour
{
    public GameObject explosionPrefab;
    private PointManager pointManager; // ScoreMagerin koodia
    // Update is called once per frame
    void Start()
    {
        pointManager = GameObject.Find("PointManager").GetComponent<PointManager>(); // ScoreManagerin koodia
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            GameObject newExplosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(newExplosion, 3f);
            Destroy(collision.gameObject);
            pointManager.UpdateScore(1);// t‰m‰ lis‰‰ ScoreManageriiin pisteen
            Destroy(gameObject);
            
        }
    }
}

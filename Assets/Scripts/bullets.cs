using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullets : MonoBehaviour
{
    public GameObject explosionPrefab;
    private PointManager pointManager;
    // Update is called once per frame
    void Start()
    {
        pointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            pointManager.UpdateScore(1);
            Destroy(gameObject);
            
        }
    }
}

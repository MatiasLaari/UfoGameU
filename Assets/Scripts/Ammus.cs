using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammus : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(speed * transform.localScale.x, 0f);
    }

    private void OnBecameInvisible()// tämän avulla luoti tuhoutuu ku
    {
        Destroy(gameObject);        // tämä tuhoaa peli objectin 
    }
}

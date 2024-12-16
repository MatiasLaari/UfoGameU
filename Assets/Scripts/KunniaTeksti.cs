using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KunniaTeksti : MonoBehaviour
{
    // Start is called before the first frame update
    
    //private Rigidbody2D rb ;
    //private void Awake()
    //{
    //    rb = GetComponent<Rigidbody2D>();
    //}
    public float screenTop;
    public float screenBottom;

    private void Update()
    {
        //rb.velocity = new Vector2(2f, 0f);
        Vector2 newPos = transform.position;
        if (transform.position.y > screenTop)
        {
            newPos.y = screenBottom;
        }

        if (transform.position.y > screenBottom)
        {
            newPos.y = screenTop;
        }

        transform.position = newPos;
    }
}

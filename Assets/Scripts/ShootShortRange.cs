using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootShortRange : MonoBehaviour
{

    public float bulletForce1;
    public GameObject bullet1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))// nappia painamalla tehd‰‰n alhaalla oleva ehto
        {

            GameObject newBullet1 = Instantiate(bullet1, transform.position, transform.rotation);// t‰‰ll‰ tuodaan peliin luoti.
            newBullet1.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * bulletForce1);// t‰ss‰ m‰‰ritell‰‰n luodin liikkuvuutta.
            Destroy(newBullet1, 1.0f);// Luodit tuhoutuvat t‰‰ll‰ annetun ajan p‰‰st‰.
        }
    }
}

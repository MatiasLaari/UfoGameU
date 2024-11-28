using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    private float _horizontalInput = 0;
    private float _verticalInput = 0;
    public int rotationSpeed = 0;
    Rigidbody2D rb2D;
    public float bulletForce;
    public GameObject bullet;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        GetPlayerInput();

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject newBullet = Instantiate (bullet, transform.position, transform.rotation);
            newBullet.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * bulletForce);
            Destroy(newBullet, 5.0f);
        }//sup1
    }

    private void FixedUpdate()
    {
        RotatePlayer();
    }

    private void GetPlayerInput()
    {
        _horizontalInput = Input.GetAxisRaw("Horizontal");
        _verticalInput = Input.GetAxisRaw("Vertical");
    }
    

    private void RotatePlayer()
    {
        float rotation = -_horizontalInput * rotationSpeed;
        transform.Rotate(Vector3.forward * rotation);
    }
}
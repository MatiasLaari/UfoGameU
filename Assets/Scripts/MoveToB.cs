using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToB : MonoBehaviour
{
    [SerializeField] private GameObject KohtiB;
    public float speed;
    public float rotationSpeed;
    
    void Start()
    {

    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, KohtiB.transform.position, speed * Time.deltaTime);
        transform.Rotate(0, 0, rotationSpeed);
    }
}

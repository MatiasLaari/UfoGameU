using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToA : MonoBehaviour
{
    [SerializeField]private GameObject KohtiA;
    public float speed;
    public float rotationSpeed;
    //public GameObject Kohti;
    //public float speed;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, KohtiA.transform.position, speed * Time.deltaTime);
        transform.Rotate(0, 0, rotationSpeed);
    }
}

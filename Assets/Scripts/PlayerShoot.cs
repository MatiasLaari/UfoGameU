using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    public GameObject ammusPrefab;
    public Transform shotPoint;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject ammusClone = (GameObject)Instantiate(ammusPrefab, shotPoint.transform.position, shotPoint.transform.rotation);
            ammusClone.transform.localScale = transform.localScale;
        }
    }
}

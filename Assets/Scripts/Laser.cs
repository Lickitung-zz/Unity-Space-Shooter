using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private float _speed = 18.0f;

    void Start()
    {
   
    }

    void Update()
    {
        transform.Translate(Vector3.up * _speed * Time.deltaTime);

        if (transform.position.y >= 11.5f)
        {
            DestroyLaser();
        } 
    }

    void DestroyLaser()
    {
        Destroy(gameObject);
    }
}

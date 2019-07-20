using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    // speed variable of 8
    private float _speed = 18.0f;


    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {

        //translate laser up
        transform.Translate(Vector3.up * _speed * Time.deltaTime);


        //if laser position is greater than 5 on the y
        //destroy the object
        if (transform.position.y >= 5)
        {
            DestroyLaser();
        }
    }

    void DestroyLaser()
    {
        Destroy(gameObject);
    }
}

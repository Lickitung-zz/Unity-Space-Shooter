using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float _speed = 4.0f;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 10, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //move down at 4 meters per second
        transform.Translate(Vector3.down * _speed * Time.deltaTime);

        //if bottom of screen
        if (transform.position.y < -5.1f)
        {
            //respawn at top (with a new random x position?)
            transform.position = new Vector3(Random.Range(-11.8f, 11.8f), 7, 0);
        }
    }
}

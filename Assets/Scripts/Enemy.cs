using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float _speed = 2.5f;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 12.5f, 0);
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
            float randomX = Random.Range(-18.0f, 12.5f);
            transform.position = new Vector3(randomX, 12.48f, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit: " + other.transform.name);
        //if other is Player
        //Destroy Us
        //damage the player

        //if other is laser
        //destroy laser
        //destroy us
    }
}

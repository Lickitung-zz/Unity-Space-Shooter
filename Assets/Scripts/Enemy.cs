using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float _speed = 2.5f;


    void Start()
    {
        transform.position = new Vector3(0, 12.5f, 0);
    }

    void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);

        if (transform.position.y < -5.1f)
        {
            float randomX = Random.Range(-18.0f, 12.5f);
            transform.position = new Vector3(randomX, 12.48f, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit: " + other.transform.name);
        //if other is Player
        if (other.tag == "Player")
        {
           
            
            Destroy(this.gameObject);
            
            Player player = other.transform.GetComponent<Player>();

            if (player != null)
            {
                player.Damage();
            }


        }

        if (other.tag == "Laser")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
     
    }
}

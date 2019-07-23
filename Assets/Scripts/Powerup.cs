using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move down at a speed of 3
        transform.Translate(Vector3.down * _speed * Time.deltaTime);

        //when leave screen, destroy this object
        if (transform.position.y < -4.54)
        {
            float randomX = Random.Range(-18.0f, 12.5f);
            transform.position = new Vector3(randomX, 11, 0);
        }

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {

            Debug.Log("Powerup collided with: " + collision);
            Destroy(this.gameObject);

            Player player = collision.transform.GetComponent<Player>();

            if (player != null)
            {
                player.TripleShotBool();
            }


        }
    }

    //OnTriggerCollison
    //Only be collectable by the Player (Tags)
}

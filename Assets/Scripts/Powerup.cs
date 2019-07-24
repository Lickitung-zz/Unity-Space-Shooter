using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.0f;
    [SerializeField] // 0 == Triple Shot, 1 == Speed, 2 == Shield
    private int powerupID;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);

        if (transform.position.y < -4.54)
        {
            Destroy(gameObject);
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
                if (powerupID == 0)
                {
                    Debug.Log("Triple Shot Powerup activated.");
                    player.TripleShotBool();
                }
                else if (powerupID == 1)
                {
                    Debug.Log("Speed Powerup activated.");
                }
                else
                {

                }
                

                //else if powerup is 1
                //play speed powerup
                //else if powerup is 2
                //shields powerup
            }


        }
    }

    //OnTriggerCollison
    //Only be collectable by the Player (Tags)
}

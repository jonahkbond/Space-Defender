using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    private Transform bullet;
    public float speed;

	
	void Start ()
    {
        bullet = GetComponent<Transform>();
       
    }

    void FixedUpdate()
    {
        bullet.position += Vector3.up * speed;


        if (bullet.position.y >= 10)
            Destroy (gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            //destroy enemy on contact
            Destroy(other.gameObject);


            SoundManager.PlaySound("enemyDestroySound");

            //destroy bullet on contact with enemy
            Destroy(gameObject);

            //Increase Player Score 
            PlayerScore.playerScore += 10;
        }
        else if (other.tag == "Base")
            Destroy(gameObject);
    }


}

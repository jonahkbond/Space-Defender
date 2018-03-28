using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Transform player;
    public float speed;
    public float maxbound, minBound;
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    private float nextFire;

	void Start ()
    {
        player = GetComponent<Transform>();	
	}
	

	void FixedUpdate ()
    {
        float h = Input.GetAxis("Horizontal");

        if (player.position.x < minBound && h < 0)
            h = 0;
        else if (player.position.x > maxbound && h > 0)
            h = 0;

        player.position += Vector3.right * h * speed;
	}

    void Update()
    {
       if(Input.GetButton("Fire1") && Time.time > nextFire)
        {
            //determine when next shot time is allowed
            nextFire = Time.time + fireRate;
            //create shot with position and rotation 
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);

            SoundManager.PlaySound("Laser Gun Sound Effect");
        }
    }
}

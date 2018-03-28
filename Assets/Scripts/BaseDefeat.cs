using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseDefeat : MonoBehaviour {

    private Transform playerBase;

	// Use this for initialization
	void Start ()
    {
        //initialize the playerBase by getting it to transform
        playerBase = GetComponent<Transform>();	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (playerBase.childCount == 0)
            //if there are zero bases left then game over is true
            GameOver.isPlayerDead = true;
	}
}

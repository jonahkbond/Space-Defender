using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    public static bool isPlayerDead = false;
    private Text gameOver;

	// Use this for initialization
	void Start ()
    {
        gameOver = GetComponent<Text>();
        gameOver.enabled = false;
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (isPlayerDead)
        {
            Time.timeScale = 0;
            //game over text displayed
            gameOver.enabled = true;
        }
	}
}

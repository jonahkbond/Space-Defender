using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {
		//check if player presses R on keyboard
        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerScore.playerScore = 0;
            GameOver.isPlayerDead = false;
            //unfreze game
            Time.timeScale = 1;

            SceneManager.LoadScene("Scene_001");
        }
	}
}

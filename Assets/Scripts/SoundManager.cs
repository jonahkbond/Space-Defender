using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static AudioClip laserSound, enemyLaserSound, enemyDestroySound, enemySpeedUpSound, scene1Music, startMenuMusic, victory;
    static AudioSource audioSrc;

	// Use this for initialization
	void Start () {

        laserSound = Resources.Load<AudioClip>("Laser Gun Sound Effect");
        enemyLaserSound = Resources.Load<AudioClip>("enemyLaserSound");
        enemyDestroySound = Resources.Load<AudioClip>("enemyDestroySound");
        enemySpeedUpSound = Resources.Load<AudioClip>("enemySpeedUpSound");
        victory = Resources.Load<AudioClip>("victory");
 

        audioSrc = GetComponent<AudioSource>();

    }
	

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "Laser Gun Sound Effect":
                audioSrc.PlayOneShot(laserSound);
                break;
            case "enemyLaserSound":
                audioSrc.PlayOneShot(enemyLaserSound);
                break;
            case "enemyDestroySound":
                audioSrc.PlayOneShot(enemyDestroySound);
                break;
            case "enemySpeedUpSound":
                audioSrc.PlayOneShot(enemySpeedUpSound);
                break;
            case "victory":
                audioSrc.PlayOneShot(victory);
                break;

        }
    }

}

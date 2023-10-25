using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//used this video to help (https://www.youtube.com/watch?v=PkNRPOrtyls&t=698s)
public class PowerUp : MonoBehaviour
{
    public PowerUpEffect powerupEffect;

    AudioManager AudioManager;

    public GameObject PowerUpUI;

    private void Awake()
    {
        AudioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    public void Resume()
    {
        PowerUpUI.SetActive(false); // on click closes the pause menu
        AudioManager.PlaySFX(AudioManager.Button);
        Time.timeScale = 1; //resumes the game
    }

    private void OnTriggerEnter2D(Collider2D collision) //detects collision
    {
        if(collision.gameObject.CompareTag("Player")) //if the object has collided with the tag called player
        {
            AudioManager.PlaySFX(AudioManager.PowerUp);
            PowerUpUI.SetActive(true);

            Destroy(gameObject); //destroys the object as soon as we collide with it
            powerupEffect.Apply(collision.gameObject); //applying powerup effect
            Time.timeScale = 0;
        }
        
    }
}

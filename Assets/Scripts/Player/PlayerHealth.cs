using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//I used (https://www.youtube.com/watch?v=bRcMVkJS3XQ&t=199s) to help me code this
public class PlayerHealth : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public Image healthBar;
    public GameManager gameManager;
    private bool isDead;

    AudioManager AudioManager;

    private void Awake()
    {
        AudioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = health; // whataver we set our health to, max health is automatically set to health
    }

    void Update()
    {
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1); //fills the player health bar

        if(health <= 0 && !isDead) //if the health goes down to 0 and the player isnt dead
        {
            AudioManager.PlaySFX(AudioManager.Death); // goes into audio manager script and plays sound effect
            isDead = true; //this lets the gameOver function only be called once, since we declared that the player is dead
            gameManager.gameOver(); // calls the game manager
            Time.timeScale = 0; 
            Debug.Log("Dead");
        }
        
    }

}

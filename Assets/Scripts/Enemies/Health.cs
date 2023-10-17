using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int health = 30;
    private int MAX_HEALTH = 30;
    AudioManager AudioManager;

    // Update is called once per frame
    private void Awake()
    {
        AudioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    public void SetHealth(int maxHealth, int health )
    {
        this.MAX_HEALTH = maxHealth;
        this.health = health;
    }

    public void Damage(int amount)
    {
        if(amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative Damage");
        }
        this.health -= amount;

        if(health <= 0)
        {
            AudioManager.PlaySFX(AudioManager.Death); // goes into audio manager script and plays sound effect
            Time.timeScale = 0;
            //Die();
        }
    }

    public void Heal(int amount)
    {
        if(amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative Healing");
        }

        bool wouldBeOverMaxHealth = health + amount > MAX_HEALTH;

        if(wouldBeOverMaxHealth)
        {
            this.health = MAX_HEALTH;
        }
        else
        {
            this.health += amount;
        }
    }

    private void Die()
    {
        //Debug.Log("I am dead");
        //Destroy(gameObject);
    }
}

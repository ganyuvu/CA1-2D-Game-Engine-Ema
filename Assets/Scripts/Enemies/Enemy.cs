using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//used this video to help me code this (https://www.youtube.com/watch?v=zYN1LTMdFYg&t=854s)
public class Enemy : MonoBehaviour
{
    [SerializeField] private float maxHealth = 10f;
    [SerializeField] private float currentHealth;
    private GameObject player;
    public PlayerHealth pHealth;
    public float enemyDamage = 10f;
    public float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player"); // finds the object with the tag "Player"
        currentHealth = maxHealth; //sets up the health when the game starts
    }

    // Update is called once per frame
    void Update()
    {
        Swarm(); // calls function
    }

     public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;
        
        if(currentHealth <= 0) //if the current health of enemy drops to 0 or less it will destroy the enemy object
        {
            Destroy(gameObject);
        }
    }

    //function to follow the player
    private void Swarm()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player")) //if enemy collides with the tag called "Player" the enemy will damage the players health
        {
            collision.gameObject.GetComponent<PlayerHealth>().health -= enemyDamage;  
        }
    }


}

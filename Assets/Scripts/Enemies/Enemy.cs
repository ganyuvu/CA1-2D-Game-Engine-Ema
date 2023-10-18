using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject player;
    public PlayerHealth pHealth;
    public float enemyDamage = 10f;
    public float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player"); // finds the object with the tag "Player"
    }

    // Update is called once per frame
    void Update()
    {
        Swarm(); // calls function
    }

    //function to follow the player
    private void Swarm()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerHealth>().health -= enemyDamage;
            
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int damage = 1;
    [SerializeField] private float speed = 2;
    [SerializeField] private EnemyData data;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player"); // finds the object with the tag "Player"
    }

    // Update is called once per frame
    void Update()
    {
        Swarm();
    }

    //function to follow the player
    private void Swarm()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }

}

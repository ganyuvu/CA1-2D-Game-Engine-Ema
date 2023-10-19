using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    [SerializeField] private float destroyTime = 3f;
    [SerializeField] private LayerMask whatDestroysBullet; 

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        SetDestroyTime();
    }

    //function to destroy bullet if it hits a certain oject or walls
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //making sure what we have collided with is within the layerMask
        if((whatDestroysBullet.value & (1 << collision.gameObject.layer)) > 0)
        {
            Destroy(gameObject);
        }
    }

    //fuction to destroy bullet after a certain amount of time
    private void SetDestroyTime()
    {
        Destroy(gameObject, destroyTime);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//used this video to help (https://www.youtube.com/watch?v=anHxFtiVuiE + https://www.youtube.com/watch?v=zYN1LTMdFYg&t=854s)
public class BulletBehavior : MonoBehaviour
{
    [SerializeField] private float destroyTime = 3f;
    [SerializeField] private LayerMask whatDestroysBullet; 
    public float gunDamage = 2f;
    private Rigidbody2D rb;
    private float damage;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        SetDestroyTime();
    }

    //function to destroy bullet if it hits a certain oject or walls // to damage enemies
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //making sure what we have collided with is within the layerMask
        if((whatDestroysBullet.value & (1 << collision.gameObject.layer)) > 0)
        {
            if(collision.gameObject.TryGetComponent<Enemy>(out Enemy enemyComponent)) // if the bullet finds the enemy collider it extracts the enemy
            {
                enemyComponent.TakeDamage(gunDamage); // calls TakeDamage() in the enemy script
            }

            Destroy(gameObject); //destroys bullet if it hits other objects
        }
    }

    //fuction to destroy bullet after a certain amount of time
    private void SetDestroyTime()
    {
        Destroy(gameObject, destroyTime);
    }
}

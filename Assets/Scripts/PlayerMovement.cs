using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//I referenced the following code from this youtube video https://www.youtube.com/watch?v=K1xZ-rycYY8&t=93s
public class PlayerMovement : MonoBehaviour
{
    private float horizontal;

    private float speed = 8f;
    
    private bool isFacingRight = true;

    //Refers to unity 
    [SerializeField] private Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        //returns the value of -1, or 1, which determines the direction the player moves
        horizontal = Input.GetAxisRaw("Horizontal");

        Flip();
    }

    //the fixed update is called a fixed amount of times per second unlike the normal update that calls once per 
    private void FixedUpdate()
    {
        //Gets the rigid bodies velocity 
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }
    //Method to flip player which depends on the value of the horizontal axis
    private void Flip()
    {
        //if the player faces right or left it will flip them
        if(isFacingRight && horizontal <0f || !isFacingRight && horizontal > 0f)
        {
            //this will flip the player by changing the x scale to -1
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}

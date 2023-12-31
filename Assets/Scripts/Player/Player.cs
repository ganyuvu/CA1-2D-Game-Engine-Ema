using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//got parts of this code from (https://www.youtube.com/watch?v=Lvk6HKmWVwE&t=153s)
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement; //stores all the movement from the vertical and horizontal movement
    private bool isFacingRight = true;
    public Animator anim;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal"); // gives value between 1 and -1 to move left or right on the horizontal axis
        movement.y = Input.GetAxisRaw("Vertical");
        anim.SetFloat("Speed", movement.sqrMagnitude); // player animation

        if(movement.x <0 && isFacingRight) //flipping player
        {
            Flip();
        }
        else if(movement.x > 0 && !isFacingRight)
        {
            Flip();
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed  * Time.fixedDeltaTime); // moves the rigidbody to a new position and makes sure player collides with anything in the way
    }

    //flip function 
    void Flip()
    {

        isFacingRight = !isFacingRight;
        transform.Rotate(0f,180f,0f);
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
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
        anim.SetFloat("Speed", movement.sqrMagnitude);
        Flip();
    }
    
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed  * Time.fixedDeltaTime); // moves the rigidbody to a new position and makes sure player collides with anything in the way
    }

    //flips the player by getting its position on horizontal axis 
    private void Flip()
    {
        if(isFacingRight && movement.x < 0f || !isFacingRight && movement.x > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

}

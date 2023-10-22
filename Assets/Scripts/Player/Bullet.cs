using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//I used this video (https://www.youtube.com/watch?v=-bkmPm_Besk&t=188s) to help me code this
public class Bullet : MonoBehaviour
{
    private Vector3 mousePos;
    private Camera mainCam;
    private Rigidbody2D rb;
    public float force;

    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>(); //we need this to find the mouse position

        rb = GetComponent<Rigidbody2D>();

        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition); // getting mouse position 

        Vector3 direction = mousePos - transform.position; //giving the bullet a direction to go in

        Vector3 rotation = transform.position - mousePos; //rotating bullet towards the cursor

        rb.velocity = new Vector2(direction.x, direction.y).normalized * force; //setting the velocity of the bullet, we normalized it so that the bullet doesnt change its speed depending on the cursors distance. Multiplying by force allows us to adjust the speed in the inspector

        float rot = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg; //Atan2 gives us an angle in radians and Rad2Deg changes radians to degrees, this creates the bullets rotation

        transform.rotation = Quaternion.Euler(0, 0, rot + 90); //rotates the z axis, adding 90 degrees to keep the bullet vertical
    }
}

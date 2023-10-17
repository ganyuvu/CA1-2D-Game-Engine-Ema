using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//I used a video linked (https://www.youtube.com/watch?v=-bkmPm_Besk&t=188s) to code this section
public class Shooting : MonoBehaviour
{
    private Camera mainCam;
    private Vector3 mousePosition;
    public GameObject bullet;
    public Transform bulletTransform;
    public bool canFire;
    private float timer; //adds a cooldown to gunshots
    public float timeBetweenFiring; //Can change in the inspector


    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = mainCam.ScreenToWorldPoint(Input.mousePosition); //sets vector to mouse postion

        Vector3 rotation = mousePosition - transform.position; //rotates the gun

        float rotateZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg; //Atan2 gives us an angle in radians and Rad2Deg changes radians to degrees, this creates the guns rotation

        transform.rotation = Quaternion.Euler(0, 0, rotateZ);

        if(!canFire) //if canFire is = to false
        {
            timer += Time.deltaTime; // timer will go up with the time of the game
            if(timer > timeBetweenFiring) //  if the timer exceeds timeBetweenFiring it will allow player to fire again      
            {
                canFire = true;
                timer = 0; // resets the timer
            }
        }

        if(Input.GetMouseButton(0) && canFire) // if left mouse is clicked, gun will shoot, however it will only fire if there is no cooldown
        {
            canFire = false;
            Instantiate(bullet, bulletTransform.position, Quaternion.identity); //Instantiates bullet prefab, the bullets position and gives it its own rotation
        }

    }

   
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject Player;
    public GameObject bullet;
    public Transform bulletTransform;
    public bool canFire;
    private float timer; //adds a cooldown to gunshots
    public float timeBetweenFiring; //Can change in the inspector

    void update()
    {
       
    }

    private void FixedUpdate()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        difference.Normalize();

        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);

        if(rotationZ < -90 || rotationZ > 90)
        {
            if(Player.transform.eulerAngles.y == 0)
            {
                transform.localRotation = Quaternion.Euler(180, 0, -rotationZ);
            }
            else if(Player.transform.eulerAngles.y == 180)
            {
                transform.localRotation = Quaternion.Euler(180,180, -rotationZ);
            }
        }

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
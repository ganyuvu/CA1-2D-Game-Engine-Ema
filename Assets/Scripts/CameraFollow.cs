using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//I referenced the following code from a youtube video https://www.youtube.com/watch?v=ZBj3LBA2vUY

public class CameraFollow : MonoBehaviour
{
    //Defines the camera offset to the player
    private Vector3 offset = new Vector3(0f, 0f,-10f);

    //Defines the aprox time for the camera to reach the target
    private float smoothTime = 0.25f;

    //Defines the cameras velocity
    private Vector3 velocity = Vector3.zero;

    //The target the camera will follow
    [SerializeField] private Transform target;

    // Update is called once per frame
    void Update()
    {
        //Adds the offset to the position of the target 
        Vector3 targetPosition = target.position + offset;
        //Gradually changes the vector to another location
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}

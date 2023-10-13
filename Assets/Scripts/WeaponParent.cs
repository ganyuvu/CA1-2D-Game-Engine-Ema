using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private Camera mainCam;
    private Vector3 mousePosition;

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

    }
}
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

//Learned to code this fron (https://www.youtube.com/watch?v=luSVUPU6bK0)
public class CameraShake : MonoBehaviour
{
    private CinemachineVirtualCamera CinemachineVirtualCamera; //reference
    private float ShakeIntensity = 2f; // to control the amplitude gain
    private float ShakeTime = 0.2f; // how long shake lasts
    private float timer; // to keep track of how long the shake lasts to know when to stop the shake
    private CinemachineBasicMultiChannelPerlin _cbmcp; // reference

    void Awake()
    {
        CinemachineVirtualCamera = GetComponent<CinemachineVirtualCamera>(); //getting and storing virtual cam component
    }

    private void Start()
    {
        StopShake(); //ensure camera doesnt start shaking when game is started
    }

    //gettingc the basic multi channel perlin and setting the amplitude gain to the shake intensity to create shake effect
    public void ShakeCamera()
    {
        CinemachineBasicMultiChannelPerlin _cbmcp = CinemachineVirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        _cbmcp.m_AmplitudeGain = ShakeIntensity;

        timer = ShakeTime; //makes sure the shake stops after a certain time
    }

   //stops shake effect
    public void StopShake()
    {
        CinemachineBasicMultiChannelPerlin _cbmcp = CinemachineVirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        _cbmcp.m_AmplitudeGain = 0f;
        timer = 0;

    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButton(0)) //if the mouse button is clicked, screen will shake
       {
        ShakeCamera();
       }

       if(timer > 0)
       {
        timer -= Time.deltaTime; //decreasing the timer like a countdown

        if(timer <= 0) // stopping the shake if timer reaches 0 or below
        {
            StopShake();
        }
       }
    }
}

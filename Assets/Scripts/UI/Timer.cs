using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//used this video (https://www.youtube.com/watch?v=POq1i8FyRyQ&t=15s)
public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;

    float elapsedTime;

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime; //gets the time
        int minutes = Mathf.FloorToInt(elapsedTime / 60); //splitting the time into mins and secs
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds); // puts the code above intto string
    }
}

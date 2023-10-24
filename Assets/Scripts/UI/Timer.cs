using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//used this video (https://www.youtube.com/watch?v=POq1i8FyRyQ&t=15s)
public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;

    //float elapsedTime;

    // Update is called once per frame
    void Update()
    {
        if(remainingTime > 0)//if time is greater than 0 count down as normal
        {
            remainingTime -= Time.deltaTime;
        }
        else if(remainingTime < 0)//if time is less than 0 stop counting and freeze game, then set winner panel active
        {
            remainingTime = 0;
            Time.timeScale = 0;
            //game over screen active here
        }
        int minutes = Mathf.FloorToInt(remainingTime / 60); //splitting the time into mins and secs
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds); // puts the code above intto string
    }
}

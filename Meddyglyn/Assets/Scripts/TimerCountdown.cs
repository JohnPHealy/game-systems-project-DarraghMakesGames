using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCountdown : MonoBehaviour
{

    public float timeRemaining = 10f;
    public bool countdown;
    public bool hasFinished = false;

    public Text timeReadout;

    public float minutes;
    public float seconds;

    private void Start()
    {
        countdown = true;
    }

    void Update()
    {
        if (countdown)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                hasFinished = true;
                Debug.Log("Time is up");
                timeRemaining = 0;
                DisplayTime(timeRemaining);
                countdown = false;
                timeRemaining = 0;
            }
        }

    }

    void DisplayTime(float timeToDisplay)
    {
        minutes = Mathf.FloorToInt(timeToDisplay / 60);
        seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeReadout.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}

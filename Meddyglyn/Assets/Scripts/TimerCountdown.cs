using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using StarterAssets;

public class TimerCountdown : MonoBehaviour
{

    public float timeRemaining = 10f;
    public bool countdown = false;
    public bool hasFinished = false;

    public Text timeReadout;

    public float minutes;
    public float seconds;

    [SerializeField] private GameObject endScreen;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject gameUI;


    public void StartCountdown()
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

        if (hasFinished)
        {
            endScreen.SetActive(true);
            gameUI.SetActive(false);
;
            player.GetComponent<FirstPersonController>().enabled = false;
            Cursor.lockState = CursorLockMode.Confined;
        }

    }

    void DisplayTime(float timeToDisplay)
    {
        minutes = Mathf.FloorToInt(timeToDisplay / 60);
        seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeReadout.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}

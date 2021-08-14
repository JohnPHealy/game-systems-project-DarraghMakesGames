using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameOverCalc : MonoBehaviour
{

    //This script generates info for the end-screen once the timer runs out

    [SerializeField] private GameObject batchesText;
    [SerializeField] private GameObject profitText;
    [SerializeField] private GameObject bronzeTrophy;
    [SerializeField] private GameObject silverTrophy;
    [SerializeField] private GameObject goldTrophy;
    private float profit;

    private void Update()
    {
        profit = GameManager.profit;
        batchesText.GetComponent<TMPro.TextMeshProUGUI>().text = "Batches made: " + GameManager.batchesMade.ToString();
        profitText.GetComponent<TMPro.TextMeshProUGUI>().text = "Profit: " + GameManager.profit.ToString();

        //Based on profits made within the time limit, this puts on outline on whatever trophy the player has earned
        if (profit >= 300)
        {
            goldTrophy.GetComponent<Outline>().enabled = true;
        }

        else if (profit >= 200 && profit < 300)
        {
            silverTrophy.GetComponent<Outline>().enabled = true;
        }
        else if (profit >= 100 && profit < 200)
        {
            bronzeTrophy.GetComponent<Outline>().enabled = true;
        }
        else
        {
            Debug.Log("Player failed at capitalism");
        }


    }

}


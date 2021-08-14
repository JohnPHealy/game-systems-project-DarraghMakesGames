using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameOverCalc : MonoBehaviour
{

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


        switch (profit)
        {
            case > 300:
                goldTrophy.GetComponent<Outline>().enabled = true;
                break;

            case > 200:
                silverTrophy.GetComponent<Outline>().enabled = true;
                break;

            case > 100:
                bronzeTrophy.GetComponent<Outline>().enabled = true;
                break;

            default:
                Debug.Log("Failed to make enough profit");
                break;
        }

    }
}

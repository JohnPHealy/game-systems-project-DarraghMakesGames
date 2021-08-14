using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverCalc : MonoBehaviour
{

    [SerializeField] private GameObject batchesText;
    [SerializeField] private GameObject profitText;

    private void Update()
    {
        batchesText.GetComponent<TMPro.TextMeshProUGUI>().text = "Batches made: " + GameManager.batchesMade.ToString();
        profitText.GetComponent<TMPro.TextMeshProUGUI>().text = "Profit: " + GameManager.profit.ToString();
    }

}

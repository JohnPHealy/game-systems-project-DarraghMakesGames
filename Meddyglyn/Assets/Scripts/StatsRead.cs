using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StatsRead : MonoBehaviour
{

    private TextMesh statsReadout;
    private int honeyAmount;
    private int waterAmount;
    private int alcoholAmount;
    private GameObject vessel;
    private string yeastStatus;

    private void Start()
    {
        statsReadout = gameObject.GetComponent<TextMesh>();
        vessel = transform.parent.gameObject;
        yeastStatus = "Yes";
        //StartCoroutine (ReadIngredients());
    }

    void Update()
    {
        honeyAmount = vessel.GetComponent<VesselManager>().honeyAmount;
        waterAmount = vessel.GetComponent<VesselManager>().waterAmount;
        alcoholAmount = vessel.GetComponent<VesselManager>().alcohol;
        statsReadout.text = "Honey: " + honeyAmount + "\n" + "Water: " + waterAmount + "Has Yeast: " + yeastStatus + "\n" + "Alcohol: " + alcoholAmount;
    }

    //IEnumerator ReadIngredients()
    //{
    //    honeyAmount = vessel.GetComponent<VesselManager>().honeyAmount;
    //    waterAmount = vessel.GetComponent<VesselManager>().waterAmount;
    //    statsReadout.text = "Honey: " + honeyAmount + "\n" + "Water: " + waterAmount + "Has Yeast: " + yeastStatus;
    //    yield return new WaitForSeconds(0.5f);
    //}

}

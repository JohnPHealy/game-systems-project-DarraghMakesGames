using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageManager : MonoBehaviour
{
    public float capacity;
    [SerializeField] float storageValue;
    [SerializeField] float honeyAmount;
    [SerializeField] float sweetness;
    [SerializeField] float citrus;
    [SerializeField] float tart;
    [SerializeField] float sour;
    [SerializeField] float bitter;
    [SerializeField] float woody;
    [SerializeField] float peppery;
    [SerializeField] float age;
    [SerializeField] float alcohol;

    public string sweetnessRating;
    public string alcoholRating;

    public bool filled = false;
    public float value;
    public float valuePerML;

    [SerializeField] private bool agingStarted;

    public void Fill(GameObject vessel)
    {
        if (!filled)
        {
            Debug.Log("Filling bottle...");
            filled = true;
            honeyAmount = vessel.GetComponent<VesselManager>().honeyStrength;
            alcohol = vessel.GetComponent<VesselManager>().alcohol;
            sweetness = vessel.GetComponent<VesselManager>().sweetnessStrength;
            citrus = vessel.GetComponent<VesselManager>().citrusStrength;
            tart = vessel.GetComponent<VesselManager>().tartStrength;
            sour = vessel.GetComponent<VesselManager>().sourStrength;
            bitter = vessel.GetComponent<VesselManager>().bitterStrength;
            woody = vessel.GetComponent<VesselManager>().woodyStrength;
            peppery = vessel.GetComponent<VesselManager>().pepperyStrength;

            valuePerML = vessel.GetComponent<ValueCalculator>().valuePerMl;

            vessel.GetComponent<VesselManager>().totalLiquidContent = vessel.GetComponent<VesselManager>().totalLiquidContent - capacity;
            agingStarted = true;
            StartCoroutine("Aging");
        }
        else
        {
            Debug.Log("Storage vessel already full");
        }

    }

    IEnumerator Aging()
    {
        while (agingStarted)
        {
            yield return new WaitForSeconds(20f);
            age++;
        }

            
    }

    private void Update()
    {
        value = (valuePerML * capacity) + storageValue;

        //This expresses the strength of the honey in human-readable terms
        //0-5 is low, 6-10 is average, 11+ is high

        if (sweetness <= 5)
        {
            sweetnessRating = "Low";
        }
        else if (sweetness > 5 && sweetness < 11)
        {
            sweetnessRating = "Average";
        }
        else if (sweetness >= 11)
        {
            sweetnessRating = "High";
        }

        //This expresses the strength of the alcohol in human-readable terms
        //0-5 is low, 6-10 is average, 11+ is high

        if (alcohol <= 5)
        {
            alcoholRating = "Low";
        }
        else if (alcohol > 5 && alcohol < 11)
        {
            alcoholRating = "Average";
        }
        else if (alcohol >= 11)
        {
            alcoholRating = "High";
        }






    }


}

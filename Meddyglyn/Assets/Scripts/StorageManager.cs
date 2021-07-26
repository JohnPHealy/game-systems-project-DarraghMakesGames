using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageManager : MonoBehaviour
{
    [SerializeField] int capacity;
    [SerializeField] int honeyAmount;
    [SerializeField] int age;
    [SerializeField] int alcohol;
    [SerializeField] bool filled = false;
    public int value;
    [SerializeField] private int sweetnessMarketValue;
    [SerializeField] private int alcoholMarketValue;
    [SerializeField] private int ageMarketValue;
    [SerializeField] private int sweetnessValue;
    [SerializeField] private int alcoholValue;
    [SerializeField] private int ageValue;
    [SerializeField] private bool agingStarted;

    public void Fill(GameObject vessel)
    {
        if (!filled)
        {
            Debug.Log("Filling bottle...");
            filled = true;
            honeyAmount = vessel.GetComponent<VesselManager>().honeyAmount;
            alcohol = vessel.GetComponent<VesselManager>().alcohol;
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
        sweetnessMarketValue = MarketValues.sweetnessValue;
        alcoholMarketValue = MarketValues.strengthValue;
        ageMarketValue = MarketValues.ageValue;

        sweetnessValue = honeyAmount * sweetnessMarketValue;
        alcoholValue = alcohol * alcoholMarketValue;
        ageValue = age * ageMarketValue;

        value = sweetnessValue + alcoholValue + ageValue;
    }


}

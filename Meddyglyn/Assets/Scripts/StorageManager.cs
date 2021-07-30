using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageManager : MonoBehaviour
{
    [SerializeField] float capacity;
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

    [SerializeField] bool filled = false;
    public float value;

    [SerializeField] private float sweetnessMarketValue;
    [SerializeField] private float alcoholMarketValue;
    [SerializeField] private float citrusMarketValue;
    [SerializeField] private float tartMarketValue;
    [SerializeField] private float sourMarketValue;
    [SerializeField] private float bitterMarketValue;
    [SerializeField] private float woodyMarketValue;
    [SerializeField] private float pepperyMarketValue;

    [SerializeField] private float ageMarketValue;
    [SerializeField] private float sweetnessValue;
    [SerializeField] private float citrusValue;
    [SerializeField] private float tartValue;
    [SerializeField] private float sourValue;
    [SerializeField] private float bitterValue;
    [SerializeField] private float woodyValue;
    [SerializeField] private float pepperyValue;
    [SerializeField] private float alcoholValue;
    [SerializeField] private float ageValue;
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
        citrusMarketValue = MarketValues.citrusValue;
        tartMarketValue = MarketValues.tartValue;
        sourMarketValue = MarketValues.sourValue;
        bitterMarketValue = MarketValues.sourValue;
        woodyMarketValue = MarketValues.woodyValue;
        pepperyMarketValue = MarketValues.pepperyValue;

        sweetnessValue = sweetness * sweetnessMarketValue;
        alcoholValue = alcohol * alcoholMarketValue;
        ageValue = age * ageMarketValue;
        citrusValue = citrus * citrusMarketValue;
        tartValue = tart * tartMarketValue;
        sourValue = sour * sourMarketValue;
        bitterValue = bitter * bitterMarketValue;
        woodyValue = woody * woodyMarketValue;
        pepperyValue = peppery * pepperyMarketValue;

        value = sweetnessValue + alcoholValue + ageValue + citrusValue + tartValue + sourValue + bitterValue + woodyValue + pepperyValue;
    }


}

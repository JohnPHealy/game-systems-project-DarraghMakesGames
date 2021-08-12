using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueCalculator : MonoBehaviour
{
    //This class takes variables from the parent vessel object to calculate the value of the product per ml - used when moving to storage

    public float rawValue;
    public float valuePerMl;
    [SerializeField] private float sweet;
    [SerializeField] private float alcohol;
    [SerializeField] private float citrus;
    [SerializeField] private float tart;
    [SerializeField] private float sour;
    [SerializeField] private float bitter;
    [SerializeField] private float woody;
    [SerializeField] private float peppery;
    [SerializeField] private float batchAmount;

    [SerializeField] private float sweetValue;
    [SerializeField] private float alcoholValue;
    [SerializeField] private float citrusValue;
    [SerializeField] private float tartValue;
    [SerializeField] private float sourValue;
    [SerializeField] private float bitterValue;
    [SerializeField] private float woodyValue;
    [SerializeField] private float pepperyValue;

    private void Update()
    {
        sweet = GetComponent<VesselManager>().sweetnessStrength;
        alcohol = GetComponent<VesselManager>().alcohol;
        citrus = GetComponent<VesselManager>().citrusStrength;
        tart = GetComponent<VesselManager>().tartStrength;
        sour = GetComponent<VesselManager>().sourStrength;
        bitter = GetComponent<VesselManager>().bitterStrength;
        woody = GetComponent<VesselManager>().bitterStrength;
        peppery = GetComponent<VesselManager>().pepperyStrength;
        batchAmount = GetComponent<VesselManager>().totalLiquidContent;

        sweetValue = sweet * 2;
        alcoholValue = alcohol * 2;
        citrusValue = citrus;
        tartValue = tart;
        sourValue = sour;
        bitterValue = bitter;
        woodyValue = woody;
        pepperyValue = peppery;

        rawValue = sweetValue + alcoholValue + citrusValue + tartValue + sourValue + bitterValue + woodyValue + pepperyValue;
        valuePerMl = rawValue / batchAmount;
}


}

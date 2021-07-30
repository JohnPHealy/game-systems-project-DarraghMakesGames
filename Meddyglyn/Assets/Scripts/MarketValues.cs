using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketValues : MonoBehaviour
{
    // Start is called before the first frame update


    public static float sweetnessValue;
    public static float strengthValue;
    public static float ageValue;
    public static float citrusValue;
    public static float tartValue;
    public static float sourValue;
    public static float bitterValue;
    public static float woodyValue;
    public static float pepperyValue;
    private bool marketRandom;


    private void Start()
    {
        marketRandom = true;
        StartCoroutine("MarketForces");
    }

    IEnumerator MarketForces()
    {
        while (marketRandom)
        {
            yield return new WaitForSeconds(10f);
            sweetnessValue = Random.Range(0.5f, 2f);
            strengthValue = Random.Range(0.5f, 2f);
            ageValue = Random.Range(1f, 1.5f);
        }

    }

}

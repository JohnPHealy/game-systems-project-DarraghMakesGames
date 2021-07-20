using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketValues : MonoBehaviour
{
    // Start is called before the first frame update

    public static int sweetnessValue;
    public static int strengthValue;
    public static int ageValue;
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
            sweetnessValue = Random.Range(1, 10);
            strengthValue = Random.Range(1, 10);
            ageValue = Random.Range(1, 10);
        }

    }

}

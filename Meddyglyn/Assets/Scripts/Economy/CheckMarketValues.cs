using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMarketValues : MonoBehaviour
{

    [SerializeField] string preferred;
    [SerializeField] string unpopular;
    private string properties;

    private void Update()
    {
        preferred = MarketValues.preferredFlavourName;
        unpopular = MarketValues.unpopularFlavourName;
        properties = "Popular flavour: " + preferred + "\n" + "Unpopular flavour: " + unpopular;
        GetComponent<ExamineItem>().uiProperties = properties;
    }

}

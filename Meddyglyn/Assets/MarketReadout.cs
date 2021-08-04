using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class MarketReadout : MonoBehaviour
{

    private GameObject marketValues;
    private TextMesh marketReadout;

    private int preferred;
    private int unpopular;
    // Start is called before the first frame update
    void Start()
    {
        marketReadout = gameObject.GetComponent<TextMesh>();
        marketValues = transform.parent.gameObject;
        preferred = marketValues.GetComponent<MarketValues>().preferredSelector;
        unpopular = marketValues.GetComponent<MarketValues>().unpopularSelector;
    }

    // Update is called once per frame
    void Update()
    {
        marketReadout.text = "Preferred selector = " + preferred + "\n" + "Unpopular selector = " + unpopular;
    }
}

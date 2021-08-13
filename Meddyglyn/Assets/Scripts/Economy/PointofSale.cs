using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointofSale : MonoBehaviour
{
    private Transform forSale;
    [SerializeField] private GameObject gold;
    [SerializeField] Transform goldPosition;
    public GameObject newGold;

    public float sellValue;
    public float adjustedSellValue;

    private bool hasItem = false;
    public float waitTime;

    public string preferredFlavour;
    public string unpopularFlavour;

    [SerializeField] float sweetness;
    [SerializeField] float citrus;
    [SerializeField] float tart;
    [SerializeField] float sour;
    [SerializeField] float bitter;
    [SerializeField] float woody;
    [SerializeField] float peppery;
    [SerializeField] float age;
    [SerializeField] float alcohol;

    [SerializeField] private float preferred;
    [SerializeField] private float unpopular;

    [SerializeField] private float preferredMultiplier;
    [SerializeField] private float unpopularMultiplier;


    void Update()
    {
        preferredFlavour = MarketValues.preferredFlavourName;
        unpopularFlavour = MarketValues.unpopularFlavourName;

        if (this.transform.childCount > 0)
        {

            forSale = this.gameObject.transform.GetChild(0);

            alcohol = forSale.GetComponent<StorageManager>().alcohol;
            sweetness = forSale.GetComponent<StorageManager>().sweetness;
            citrus = forSale.GetComponent<StorageManager>().citrus;
            tart = forSale.GetComponent<StorageManager>().tart;
            sour = forSale.GetComponent<StorageManager>().sour;
            bitter = forSale.GetComponent<StorageManager>().bitter;
            woody = forSale.GetComponent<StorageManager>().woody;
            peppery = forSale.GetComponent<StorageManager>().peppery;

            CheckValues();

            //If the preferred flavour is present, set the popular value multiplier to 1.5
                if (preferred > 0)
            {
                preferredMultiplier = 1.5f;
            }
                else if (preferred == 0)
            {
                preferredMultiplier = 1;
            }

            //If the unpopoular flavour is present, set the unpopular value multiplier to 0.5
                if (unpopular > 0)
            {
                unpopularMultiplier = 0.5f;
            }
                else if (unpopular == 0)
            {
                unpopularMultiplier = 1;
            }

            //Base sell value is retrieved from the storage being sold
            sellValue = forSale.GetComponent<StorageManager>().value;

            //Multipliers are then applied based on comparing flavours against the current market
            adjustedSellValue = (sellValue * preferredMultiplier) * unpopularMultiplier;



            if (!hasItem)
            {
                StartCoroutine("SellItem");
                hasItem = true;
            }

        }
    }

    IEnumerator SellItem()
    {
        waitTime = Random.Range(20, 30);
        yield return new WaitForSeconds(waitTime);
        Destroy(forSale.gameObject);
        Debug.Log("Item sold!");
        hasItem = false;

        //Instantiates a pile of gold coins and passes the sale value to the gold for pickup
        newGold = Instantiate(gold, goldPosition);
        newGold.SendMessage("SetValue", adjustedSellValue);

    }


    private void CheckValues()
    {
        switch (preferredFlavour)
        {
            case "Citrus":
                preferred = citrus;
                break;

            case "Tart":
                preferred = tart;
                break;

            case "Sour":
                preferred = sour;
                break;

            case "Bitter":
                preferred = bitter;
                break;

            case "Woody":
                preferred = woody;
                break;

            case "Peppery":
                preferred = peppery;
                break;

            default:
                Debug.Log("Can't read preferred value");
                break;
        }

        switch (unpopularFlavour)
        {
            case "Citrus":
                unpopular = citrus;
                break;

            case "Tart":
                unpopular = tart;
                break;

            case "Sour":
                unpopular = sour;
                break;

            case "Bitter":
                unpopular = bitter;
                break;

            case "Woody":
                unpopular = woody;
                break;

            case "Peppery":
                unpopular = peppery;
                break;

            default:
                Debug.Log("Can't read unpopular value");
                break;
        }

    }
    

}

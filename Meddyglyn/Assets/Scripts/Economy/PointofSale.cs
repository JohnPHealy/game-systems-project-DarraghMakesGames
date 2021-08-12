using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointofSale : MonoBehaviour
{

    private GameObject MarketManager;
    private Transform forSale;
    [SerializeField] private GameObject gold;
    [SerializeField] Transform goldPosition;
    public GameObject newGold;

    public float sellValue;
    private bool hasItem = false;
    public float waitTime;

    public string preferredFlavour;
    public string unpopularFlavour;

    private void Start()
    {

        MarketManager = GameObject.Find("MarketManager");

    }


    void Update()
    {
        if (this.transform.childCount > 0)
        {

            forSale = this.gameObject.transform.GetChild(0);
            sellValue = forSale.GetComponent<StorageManager>().value;
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
        newGold = Instantiate(gold, goldPosition);
        newGold.SendMessage("SetValue", sellValue);

    }
    

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointofSale : MonoBehaviour
{
    private GameObject GoldCount;
    private Transform forSale;
    private float sellValue;

    private void Start()
    {
        GoldCount = GameObject.Find("GoldCount");
    }


    void Update()
    {
        if (this.transform.childCount > 0)
        {
            forSale = this.gameObject.transform.GetChild(0);
            sellValue = forSale.GetComponent<StorageManager>().value;
            GoldCount.gameObject.SendMessage("AddGold", sellValue);
            Destroy(forSale.gameObject);
            Debug.Log("Item sold!");
        }
    }
}

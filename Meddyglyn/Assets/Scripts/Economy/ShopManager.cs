using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    private Transform carriedPos;
    [SerializeField] private GameObject GoldCount;
    [SerializeField] private GameObject itemForSale;
    [SerializeField] private int cost;
    [SerializeField] private int currentGold;
    private GameObject CarriedObject;

    // Start is called before the first frame update
    void Start()
    {
        CarriedObject = GameObject.Find("CarriedObject");
        carriedPos = CarriedObject.transform;

    }

    public void Interacted()
    {
        GoldCount = GameObject.Find("GoldCount");
        currentGold = GoldCount.GetComponent<GoldCount>().gold;
        if (CarriedObject.transform.childCount > 0)
        {
            Debug.Log("Already carrying something!");
        }
        else if (currentGold >= cost)
        {
            Instantiate(itemForSale, carriedPos.position, carriedPos.rotation, carriedPos);
            GoldCount.gameObject.SendMessage("SpendGold", cost);
            Debug.Log("Item bought");
        }
        else if (currentGold < cost)
        {
            Debug.Log("Can't afford!");
        }

    }
}

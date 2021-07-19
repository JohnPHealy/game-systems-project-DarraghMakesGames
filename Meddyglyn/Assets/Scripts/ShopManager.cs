using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    private Transform carriedPos;
    private GameObject GoldCount;
    [SerializeField] private GameObject itemForSale;
    [SerializeField] private int cost;
    private GameObject CarriedObject;

    // Start is called before the first frame update
    void Start()
    {
        CarriedObject = GameObject.Find("CarriedObject");
        carriedPos = GameObject.Find("CarriedObject").transform;
        GoldCount = GameObject.Find("GoldCount");
    }

    public void Interacted()
    {
        if (CarriedObject.transform.childCount > 0)
        {
            Debug.Log("Already carrying something!");
        }
        else
        {
            Instantiate(itemForSale, carriedPos.position, carriedPos.rotation, carriedPos);
            GoldCount.gameObject.SendMessage("spendGold", cost);
            Debug.Log("Item bought");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyAdditionalVessel : MonoBehaviour
{

    [SerializeField] private GameObject vessel;
    [SerializeField] private GameObject GoldCount;
    [SerializeField] private int cost;
    [SerializeField] private int currentGold;
    public void Interacted()
    {
        GoldCount = GameObject.Find("GoldCount");
        currentGold = GoldCount.GetComponent<GoldCount>().gold;

        if (currentGold >= cost)
        {
            vessel.SetActive(true);
            GoldCount.gameObject.SendMessage("SpendGold", cost);
            Debug.Log("Item bought");
            this.gameObject.SetActive(false);
        }
        else if (currentGold < cost)
        {
            GoldCount.gameObject.SendMessage("CannotAfford", cost);
            Debug.Log("Can't afford!");
        }

    }

}

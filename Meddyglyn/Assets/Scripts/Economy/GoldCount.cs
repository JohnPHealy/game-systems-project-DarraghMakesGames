using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldCount : MonoBehaviour
{

    public int gold = 25;
    public Text goldReadout;
    [SerializeField] private GameObject affordNotification;

    private void Update()
    {
        goldReadout.text = gold + "gp";
    }

    //Function to reduce gold count by the amount defined in "cost". Called by shops using ShopManager.cs
    void SpendGold(int cost)
    {
        gold -= cost;
    }

    //Function to add gold when items are sold. Called by counters using PointofSale.cs
    public void AddGold (int profit)
    {
        gold += profit;
        GameManager.profit += profit;
    }

    //Displays a notification if the player tries to buy something they can't afford
    public void CannotAfford()
    {
        affordNotification.SetActive(true);
    }

}

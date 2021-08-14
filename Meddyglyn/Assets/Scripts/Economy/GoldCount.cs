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

    //Function to reduce gold count by the amount defined in "cost"
    void SpendGold(int cost)
    {
        gold -= cost;
    }

    public void AddGold (int profit)
    {
        gold += profit;
        GameManager.profit += profit;
    }

    public void CannotAfford()
    {
        affordNotification.SetActive(true);
    }

}

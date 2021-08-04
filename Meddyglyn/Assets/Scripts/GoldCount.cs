using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldCount : MonoBehaviour
{

    [SerializeField] private int gold = 25;
    public Text goldReadout;

    private void Update()
    {
        goldReadout.text = "GOLD: " + gold;
    }

    //Function to reduce gold count by the amount defined in "cost"
    void SpendGold(int cost)
    {
        gold -= cost;
    }

    void AddGold (int profit)
    {
        gold += profit;
    }

}

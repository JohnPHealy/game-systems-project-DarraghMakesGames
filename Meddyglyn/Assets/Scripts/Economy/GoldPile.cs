using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldPile : MonoBehaviour
{

    public float value;
    private GameObject GoldCount;

    private void Start()
    {
        GoldCount = GameObject.Find("GoldCount");
    }

    public void SetValue(float setValue)
    {
        value = setValue;
    }

    public void Interacted()
    {
        GoldCount.SendMessage("AddGold", value);
        Destroy(this.gameObject);
    }


}

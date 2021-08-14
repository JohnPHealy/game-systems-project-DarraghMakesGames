using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldPile : MonoBehaviour
{

    public float value;
    private GameObject GoldCount;
    private string properties;

    private void Start()
    {
        GoldCount = GameObject.Find("GoldCount");
    }

    public void SetValue(float setValue)
    {
        value = setValue;
        properties = value.ToString() + " gold pieces";
        GetComponent<ExamineItem>().uiProperties = properties;
    }

    public void Interacted()
    {
        GoldCount.SendMessage("AddGold", value);
        Destroy(this.gameObject);
    }


}

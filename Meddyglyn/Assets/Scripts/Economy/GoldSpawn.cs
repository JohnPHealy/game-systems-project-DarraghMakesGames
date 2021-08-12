using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldSpawn : MonoBehaviour
{

    private float value;
    private GameObject gold;
    [SerializeField] private GameObject pointOfSale;

    private void Start()
    {
        value = pointOfSale.GetComponent<PointofSale>().sellValue;
    }

    void Update()
    {
        if (this.transform.childCount > 0)
        {
            gold = this.transform.GetChild(0).gameObject;
            gold.SendMessage("SetValue", value);
        }

        
    }

}

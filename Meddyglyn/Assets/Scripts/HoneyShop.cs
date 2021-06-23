using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoneyShop : MonoBehaviour
{
    [SerializeField] private Transform carriedPos;
    [SerializeField] private GameObject Honey100;
    [SerializeField] private GameObject GoldCount;
    private GameObject CarriedObject;

    // Start is called before the first frame update
    void Start()
    {
        CarriedObject = GameObject.Find("CarriedObject");
    }

    public void Interacted()
    {
        if(CarriedObject.transform.childCount > 0)
        {
            Debug.Log("Already carrying something!");
        }
        else
        {
            Instantiate(Honey100, carriedPos.position, carriedPos.rotation, carriedPos);
            GoldCount.gameObject.SendMessage("spendGold", 5.0);
            Debug.Log("Picked up honey");
        }
    }
 
}

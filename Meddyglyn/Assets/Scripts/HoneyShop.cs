using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoneyShop : MonoBehaviour
{

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
            Debug.Log("Picked up honey");
        }
    }
 
}

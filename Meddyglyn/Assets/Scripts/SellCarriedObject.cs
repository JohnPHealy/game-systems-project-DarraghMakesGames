using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellCarriedObject : MonoBehaviour
{

    private GameObject CarriedObject;
    private GameObject carriedObj;
    private Transform carried;
    private Transform salesPosition;
    private Vector3 salesPos;

    private void Start()
    {
        CarriedObject = GameObject.Find("CarriedObject");
        salesPosition = this.gameObject.transform.GetChild(0);
        salesPos = salesPosition.position;
    }

    public void Interacted()
    {
        if (CarriedObject.transform.childCount < 1)
        {
            Debug.Log("Not carrying anything");
        }
        else
        {
            carried = CarriedObject.gameObject.transform.GetChild(0);
            carriedObj = carried.transform.gameObject;

            if (carriedObj.gameObject.CompareTag("Ingredient"))
            {
                Debug.Log("Can't sell raw ingredients");
            }

            else if (carriedObj.gameObject.CompareTag("Storage"))
            {
                Debug.Log("Selling bottle");
                carried.position = salesPos;
                carried.rotation = Quaternion.identity;
                carried.transform.parent = salesPosition;

            }
        }
    }

}

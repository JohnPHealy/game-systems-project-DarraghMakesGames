using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreKeg : MonoBehaviour
{

    private GameObject CarriedObject;
    private GameObject carriedObj;
    private Transform carried;
    private Transform placedPosition;
    private Vector3 placedPos;

    private Quaternion storageRotation;

    private bool hasItem = false;

    private void Start()
    {
        CarriedObject = GameObject.Find("CarriedObject");
        placedPosition = this.gameObject.transform.GetChild(0);
        placedPos = placedPosition.position;
        storageRotation = Quaternion.Euler(90f, 0, 0);

    }

    private void Update()
    {
        if (placedPosition.gameObject.transform.childCount > 0)
        {
            hasItem = true;
        }
        else if (placedPosition.gameObject.transform.childCount <= 0)
        {
            hasItem = false;
        }
    }

    public void Interacted()
    {
        if (CarriedObject.transform.childCount < 1)
        {
            Debug.Log("Not carrying anything");
        }
        else if (!hasItem)
        {
            carried = CarriedObject.gameObject.transform.GetChild(0);
            
            
            carriedObj = carried.transform.gameObject;

            if (carriedObj.gameObject.CompareTag("Ingredient"))
            {
                Debug.Log("Can't sell raw ingredients");
            }

            else if (carriedObj.gameObject.CompareTag("Storage"))
            {
                Debug.Log("Storing bottle");
                //carried.position = placedPos;
                //carried.rotation = Quaternion.identity;
                carried.transform.parent = placedPosition;
                carried.localPosition = new Vector3(0.336f, 0.061f, -0.032f);
                carried.localRotation = storageRotation;
                CarriedObject.GetComponent<CarryingManager>().playPlaceSound();

            }
        }

        else
        {
            Debug.Log("No room for this");
        }
    }

}

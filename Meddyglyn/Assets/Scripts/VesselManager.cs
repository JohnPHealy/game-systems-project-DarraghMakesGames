using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VesselManager : MonoBehaviour
{

    private GameObject CarriedObject;
    private GameObject carriedObj;
    private Transform carried;
    
    [SerializeField] private int honeyAmount;
    [SerializeField] private int honeyAdd;
    [SerializeField] private int waterAmount;
    [SerializeField] private int waterAdd;
    [SerializeField] private int yeastAdd;
    [SerializeField] private bool hasYeast;
    [SerializeField] private bool isStarted;

    // Start is called before the first frame update
    void Start()
    {
        CarriedObject = GameObject.Find("CarriedObject");
    }

    private void Interacted()
    {
        if (CarriedObject.transform.childCount < 1)
        {
            Debug.Log("Not carrying anything");
        }
        else
        {
            carried = CarriedObject.gameObject.transform.GetChild(0);
            carriedObj = carried.transform.gameObject;
            honeyAdd = carriedObj.GetComponent<IngredientValues>().honey;
            waterAdd = carriedObj.GetComponent<IngredientValues>().water;
            yeastAdd = carriedObj.GetComponent<IngredientValues>().yeast;

            honeyAmount = honeyAmount + honeyAdd/2;
            honeyAdd = 0;
            waterAmount = waterAmount + waterAdd/2;
            waterAdd = 0;
            
            if (yeastAdd > 0)
            {
                hasYeast = true;
            }

            Destroy(carriedObj);
        }
    }


}

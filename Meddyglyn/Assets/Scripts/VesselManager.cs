using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VesselManager : MonoBehaviour
{

    private GameObject CarriedObject;
    private GameObject carriedObj;
    private Transform carried;
    
    [SerializeField] public int honeyAmount;
    [SerializeField] private int honeyAdd;
    [SerializeField] public int waterAmount;
    [SerializeField] private int waterAdd;
    [SerializeField] private int yeastAdd;
    [SerializeField] public bool hasYeast;
    [SerializeField] private bool isStarted;
    [SerializeField] private int alcohol;
    [SerializeField] private int yeastTolerance;
    [SerializeField] private int totalLiquidContent;
    [SerializeField] private int maxLiquidContent;

    // Start is called before the first frame update
    void Start()
    {
        CarriedObject = GameObject.Find("CarriedObject");
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
            honeyAdd = carriedObj.GetComponent<IngredientValues>().honey;
            waterAdd = carriedObj.GetComponent<IngredientValues>().water;
            yeastAdd = carriedObj.GetComponent<IngredientValues>().yeast;

            honeyAmount = honeyAmount + honeyAdd/2;
            //honeyAdd = 0;
            waterAmount = waterAmount + waterAdd/2;
            //waterAdd = 0;
            totalLiquidContent = waterAmount + honeyAmount;
            
            if (yeastAdd > 0)
            {
                hasYeast = true;
            }

            Destroy(carriedObj);
        }
    }

    private void Update()
    {
        if (hasYeast && honeyAmount > 0)
        {
            honeyAmount = honeyAmount - 10;
            alcohol = alcohol + 1;
        }
    }


}

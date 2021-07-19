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
    [SerializeField] private int ingredientAmount;
    [SerializeField] private int capacityRemaining;

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
            capacityRemaining = maxLiquidContent - totalLiquidContent;
            carried = CarriedObject.gameObject.transform.GetChild(0);
            carriedObj = carried.transform.gameObject;
            ingredientAmount = carriedObj.GetComponent<IngredientValues>().amount;
            honeyAdd = carriedObj.GetComponent<IngredientValues>().honey;
            waterAdd = carriedObj.GetComponent<IngredientValues>().water;
            yeastAdd = carriedObj.GetComponent<IngredientValues>().yeast;

                if (capacityRemaining > ingredientAmount || yeastAdd > 0)
                {
                    honeyAmount = honeyAmount + honeyAdd / 2;
                    //honeyAdd = 0;
                    waterAmount = waterAmount + waterAdd / 2;
                    //waterAdd = 0;
                    totalLiquidContent = waterAmount + honeyAmount;

                    if (yeastAdd > 0)
                    {
                        hasYeast = true;
                        yeastTolerance = carriedObj.GetComponent<IngredientValues>().yeastTolerance;
                    }

                    Destroy(carriedObj);
                }
                else
                {
                    Debug.Log("Not enough room in vessel");

                }
        }
    }

    private void Update()
    {
        if (hasYeast && honeyAmount > 0 && isStarted == false)
        {
            StartCoroutine("fermentation");
            isStarted = true;
    //        honeyAmount = honeyAmount - 10;
    //        alcohol = alcohol + 1;
        }
    }

    IEnumerator fermentation()
    {
        while (alcohol < yeastTolerance)
        {
            yield return new WaitForSeconds(5f);
            honeyAmount = honeyAmount - 10;
            alcohol = alcohol + 1;
            
        }
    }

}

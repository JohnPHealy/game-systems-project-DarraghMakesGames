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
    [SerializeField] private float sweetness;

    [SerializeField] private float honeyAmountFloat;
    [SerializeField] private float totalLiquidContentFloat;

    [SerializeField] private bool isStarted;
    [SerializeField] public int alcohol;
    [SerializeField] private int yeastTolerance;
    [SerializeField] private int totalLiquidContent;
    [SerializeField] private int maxLiquidContent;
    [SerializeField] private int ingredientAmount;
    [SerializeField] private int capacityRemaining;
    [SerializeField] public GameObject vesselObj;

    

    // Finding the CarriedObject gameObject as a target for retrieving values
    void Start()
    {
        CarriedObject = GameObject.Find("CarriedObject");
        vesselObj = this.gameObject;
    }

    // When interacted with, this function looks in the player's hand (CarriedObject) for a child (object being carried)
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

                // If the carried object is of "Ingredient" type, values from that object are added to the vessel and the carried object is destroyed
                if (carriedObj.gameObject.CompareTag("Ingredient"))
                {
                    capacityRemaining = maxLiquidContent - totalLiquidContent;

                    ingredientAmount = carriedObj.GetComponent<IngredientValues>().amount;
                    honeyAdd = carriedObj.GetComponent<IngredientValues>().honey;
                    waterAdd = carriedObj.GetComponent<IngredientValues>().water;
                    yeastAdd = carriedObj.GetComponent<IngredientValues>().yeast;
                        
                        //Ingredients are only added if there is room in the vessel
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
                    // If the carried object is of type "Storage", the following triggers the "Fill" function of the storage object
                    else if (carriedObj.gameObject.CompareTag("Storage"))
                        {
                        Debug.Log("Vessel to fill the bottle");
                        carriedObj.gameObject.SendMessage("Fill", vesselObj);
                        }
        }
    }

    private void Update()
    {
        if (!isStarted)
        {
            //Using cast expressions to convert honeyAmount and totalLiquidContent values to floats to allow division
            float honeyAmountFloat = (float)honeyAmount;
            float totalLiquidContentFloat = (float)totalLiquidContent;
            //Sweetness is then expressed as a % of the total volume of the vessel
            sweetness = honeyAmountFloat / totalLiquidContentFloat * 100;
            //Then rounded to nearest whole number to make fermentation process more precise
            sweetness = Mathf.Round(sweetness);
        }

        // This code checks if the vessel has both yeast and sweetness - if it does, fermentation begins
        if (hasYeast && sweetness > 0 && isStarted == false)
        {
            StartCoroutine("fermentation");
            isStarted = true;
        }
    }

    //The below coroutine over time converts the honey value into alcohol
    IEnumerator fermentation()
    {
        while (alcohol < yeastTolerance && honeyAmount > 0)
        {
            yield return new WaitForSeconds(5f);
            sweetness = sweetness - 0.5f;
            alcohol = alcohol + 1;
            
        }
    }

}

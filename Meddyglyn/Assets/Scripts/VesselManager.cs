using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VesselManager : MonoBehaviour
{

    private GameObject CarriedObject;
    private GameObject carriedObj;
    private Transform carried;
    
    public int honeyAmount;
    public int waterAmount;
    public int citrusAmount;
    public int tartAmount;
    public int sourAmount;
    public int bitterAmount;
    public int woodyAmount;
    public int pepperyAmount;
    [SerializeField] private int honeyAdd;
    [SerializeField] private int waterAdd;
    [SerializeField] private int yeastAdd;
    [SerializeField] private int citrusAdd;
    [SerializeField] private int tartAdd;
    [SerializeField] private int sourAdd;
    [SerializeField] private int bitterAdd;
    [SerializeField] private int woodyAdd;
    [SerializeField] private int pepperyAdd;


    public bool hasYeast;
    [SerializeField] private float sweetness;

    [SerializeField] private float honeyAmountFloat;
    [SerializeField] private float totalLiquidContentFloat;

    [SerializeField] private bool isStarted;
    public int alcohol;
    [SerializeField] private int yeastTolerance;
    public int totalLiquidContent;
    [SerializeField] private int maxLiquidContent;
    [SerializeField] private int ingredientAmount;
    [SerializeField] private int capacityRemaining;
    public GameObject vesselObj;

    

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
                    citrusAdd = carriedObj.GetComponent<IngredientValues>().citrus;
                    tartAdd = carriedObj.GetComponent<IngredientValues>().tart;
                    sourAdd = carriedObj.GetComponent<IngredientValues>().sour;
                    bitterAdd = carriedObj.GetComponent<IngredientValues>().bitter;
                    woodyAdd = carriedObj.GetComponent<IngredientValues>().woody;
                    pepperyAdd = carriedObj.GetComponent<IngredientValues>().peppery;

                //Ingredients are only added if there is room in the vessel
                if (capacityRemaining >= ingredientAmount || yeastAdd > 0)
                        {
                            honeyAmount += honeyAdd;
                            waterAmount += waterAdd;
                            citrusAmount += citrusAdd;
                            tartAmount += tartAdd;
                            sourAmount += sourAdd;
                            bitterAmount += bitterAdd;
                            woodyAmount += woodyAdd;
                            pepperyAmount += pepperyAdd;

                            totalLiquidContent += ingredientAmount;

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
                    // If the carried object is of type "Storage", the following triggers the "Fill" function of the storage object using this object as the parameter
                    else if (carriedObj.gameObject.CompareTag("Storage"))
                        {
                        Debug.Log("Vessel to fill the bottle");
                        carriedObj.gameObject.SendMessage("Fill", vesselObj);
                                //If transferring to the storage container would fully empty the vessel, this calls the EmptyVessel function to clear values
                                if (totalLiquidContent < 1)
                                    {
                                        EmptyVessel();
                                    }
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
            StartCoroutine("Fermentation");
            isStarted = true;
        }
    }

    //The below coroutine over time converts the sweetness value into alcohol
    IEnumerator Fermentation()
    {
        while (alcohol < yeastTolerance && honeyAmount > 0)
        {
            yield return new WaitForSeconds(5f);
            sweetness -= 0.5f;
            alcohol ++;
            
        }
    }

    //This resets all varirables to their default value - vessel ready for next batch
    public void EmptyVessel()
    {
        honeyAmount = 0;
        waterAmount = 0;
        totalLiquidContent = 0;
        yeastAdd = 0;
        hasYeast = false;
        isStarted = false;
        alcohol = 0;
        yeastTolerance = 0;
        ingredientAmount = 0;
        capacityRemaining = maxLiquidContent;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketValues : MonoBehaviour
{

    public static float honeyValue;
    public static float sweetnessValue;
    public static float strengthValue;
    public static float ageValue;
    public static float citrusValue;
    public static float tartValue;
    public static float sourValue;
    public static float bitterValue;
    public static float woodyValue;
    public static float pepperyValue;
    private bool marketRandom;

    private float preferredFlavour;
    public int preferredSelector;
    private float unpopularFlavour;
    public int unpopularSelector;

    public static string preferredFlavourName = "Citrus";
    public static string unpopularFlavourName = "Bitter";

    [SerializeField] private float marketInterval = 15f;


    private void Start()
    {
        citrusValue = 1f;
        tartValue = 1f;
        sourValue = 1f;
        bitterValue = 1f;
        woodyValue = 1f;
        pepperyValue = 1f;
        preferredFlavour = 2f;
        unpopularFlavour = 0.1f;
        marketRandom = true;
        StartCoroutine("MarketForces");
    }

    IEnumerator MarketForces()
    {
        while (marketRandom)
        {
            yield return new WaitForSeconds(marketInterval);
            
            sweetnessValue = Random.Range(0.5f, 2f);
            strengthValue = Random.Range(0.5f, 2f);
            ageValue = Random.Range(1f, 1.5f);

            //Values are reset to default
            citrusValue = 1f;
            tartValue = 1f;
            sourValue = 1f;
            bitterValue = 1f;
            woodyValue = 1f;
            pepperyValue = 1f;

            //The following randomly selects a flavour as "Preferred" and another as "Unpopular"

            preferredSelector = Random.Range(1, 6);
            unpopularSelector = Random.Range(1, 6);

                //This ensures the same flavour is not chosen for both
                while (unpopularSelector == preferredSelector)
            {
                unpopularSelector = Random.Range(1, 6);
            }

                //Preferred flavour assignment
                if (preferredSelector == 1)
            {
                citrusValue = preferredFlavour;
                Debug.Log("Preferred Flavour: Citrus");
                preferredFlavourName = "Citrus";
            }
                else if (preferredSelector == 2)
            {
                tartValue = preferredFlavour;
                Debug.Log("Preferred Flavour: Tart");
                preferredFlavourName = "Tart";
            }
                else if (preferredSelector == 3)
            {
                sourValue = preferredFlavour;
                Debug.Log("Preferred Flavour: Sour");
                preferredFlavourName = "Sour";
            }
                else if (preferredSelector == 4)
            {
                bitterValue = preferredFlavour;
                Debug.Log("Preferred Flavour: Bitter");
                preferredFlavourName = "Bitter";
            }
                else if (preferredSelector == 5)
            {
                woodyValue = preferredFlavour;
                Debug.Log("Preferred Flavour: Woody");
                preferredFlavourName = "Woody";
            }
                else if (preferredSelector == 6)
            {
                pepperyValue = preferredFlavour;
                Debug.Log("Preferred Flavour: Peppery");
                preferredFlavourName = "Peppery";
            }
                else
            {
                Debug.Log("Preferred flavour error");
                preferredFlavourName = "Null";
            }


            //Unpopular flavour assignment
            if (unpopularSelector == 1)
            {
                citrusValue = unpopularFlavour;
                Debug.Log("Unpopular Flavour: Citrus");
                unpopularFlavourName = "Citrus";
            }
            else if (unpopularSelector == 2)
            {
                tartValue = unpopularFlavour;
                Debug.Log("Unpopular Flavour: Tart");
                unpopularFlavourName = "Tart";
            }
            else if (unpopularSelector == 3)
            {
                sourValue = unpopularFlavour;
                Debug.Log("Unpopular Flavour: Sour");
                unpopularFlavourName = "Sour";
            }
            else if (unpopularSelector == 4)
            {
                bitterValue = unpopularFlavour;
                Debug.Log("Unpopular Flavour: Bitter");
                unpopularFlavourName = "Bitter";
            }
            else if (unpopularSelector == 5)
            {
                woodyValue = unpopularFlavour;
                Debug.Log("Unpopular Flavour: Woody");
                unpopularFlavourName = "Woody";
            }
            else if (unpopularSelector == 6)
            {
                pepperyValue = unpopularFlavour;
                Debug.Log("Unpopular Flavour: Peppery");
                unpopularFlavourName = "Peppery";
            }
            else
            {
                Debug.Log("Unpopular flavour error");
                unpopularFlavourName = "Null";
            }



        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageManager : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] int honeyAmount;
    [SerializeField] int age;
    [SerializeField] int alcohol;
    [SerializeField] bool filled = false;
    

    public void Fill(GameObject vessel)
    {
        Debug.Log("Filling bottle...");
        filled = true;
        honeyAmount = vessel.GetComponent<VesselManager>().honeyAmount;
        alcohol = vessel.GetComponent<VesselManager>().alcohol;

    }


}

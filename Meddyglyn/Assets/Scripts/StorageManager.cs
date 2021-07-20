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
    [SerializeField] public int value;
    private bool agingStarted;
    

    public void Fill(GameObject vessel)
    {
        if (!filled)
        {
            Debug.Log("Filling bottle...");
            filled = true;
            honeyAmount = vessel.GetComponent<VesselManager>().honeyAmount;
            alcohol = vessel.GetComponent<VesselManager>().alcohol;
            agingStarted = true;
            StartCoroutine("Aging");
        }
        else
        {
            Debug.Log("Storage vessel already full");
        }

    }

    IEnumerator Aging()
    {
        while (agingStarted)
        {
            yield return new WaitForSeconds(20f);
            age++;
        }

            
    }


}

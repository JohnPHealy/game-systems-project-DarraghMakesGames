using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleScript : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject bottleObj;
    [SerializeField] private GameObject cork;
    [SerializeField] private GameObject liquid;
    private bool isFilled;

    private void Update()
    {
        isFilled = bottleObj.GetComponent<StorageManager>().filled;

        if (isFilled)
        {
            cork.SetActive(true);
            liquid.SetActive(true);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointofSale : MonoBehaviour
{

    private Transform forSale;

    // Update is called once per frame
    void Update()
    {
        if (this.transform.childCount > 0)
        {
            forSale = this.gameObject.transform.GetChild(0);
            Destroy(forSale.gameObject);
            Debug.Log("Item sold!");
        }
    }
}

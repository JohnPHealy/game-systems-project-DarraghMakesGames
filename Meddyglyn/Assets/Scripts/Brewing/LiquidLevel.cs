using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiquidLevel : MonoBehaviour
{
    [SerializeField] private GameObject vessel;

    private float totalLiquid;
    private float maxLiquid;
    public float fullness;
    private Vector3 liquidHeight;

    private void Update()
    {
        //This gets the fullness level of the vessel (from 0 to 1) and sets the y scale (height) of the liquid accordingly
        totalLiquid = vessel.GetComponent<VesselManager>().totalLiquidContent;
        maxLiquid = vessel.GetComponent<VesselManager>().maxLiquidContent;
        fullness = totalLiquid / maxLiquid;
        liquidHeight = new Vector3(1f, fullness, 1f);
        this.transform.localScale = liquidHeight;

        if (totalLiquid == 0f)
        {
            this.gameObject.SetActive(false);
        }

    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarryingManager : MonoBehaviour
{

    private Transform carried;

    public void DropCarrying()
    {
        if(this.gameObject.transform.childCount > 0)
        {
            carried = this.gameObject.transform.GetChild(0);
            carried.GetComponent<Rigidbody>().useGravity = true;
            carried.transform.parent = null;
        }
        else
        {
            Debug.Log("Not carrying anything!");
        }
    }
}

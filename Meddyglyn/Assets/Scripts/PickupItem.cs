using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    private Transform carriedPos;
    private GameObject CarriedObject;

    // Start is called before the first frame update
    void Start()
    {
        CarriedObject = GameObject.Find("CarriedObject");
        carriedPos = GameObject.Find("CarriedObject").transform;
    }

    public void Interacted()
    {
        if (CarriedObject.transform.childCount > 0)
        {
            Debug.Log("Already carrying something!");
        }
        else
        {
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<MeshCollider>().enabled = false;
            this.transform.parent = carriedPos;
            this.transform.position = carriedPos.position;
            this.transform.localRotation = Quaternion.identity;
            Debug.Log("Item picked up");
        }
    }
}

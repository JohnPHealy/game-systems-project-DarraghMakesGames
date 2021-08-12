using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBehaviour : MonoBehaviour
{
    public Transform parent;

    //A simple script to remove the water prefab from the game if it has no parent
    //Water is free & single use, so the player does not need to store / drop / pick it up
    private void Update()
    {
        parent = this.transform.parent;

        if (parent == null)
        {
            Destroy(gameObject);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearNotification : MonoBehaviour
{

    void Awake()
    {
        StartCoroutine("ClearNotif");
    }

    IEnumerator ClearNotif()
    {
        yield return new WaitForSeconds(5f);
        this.gameObject.SetActive(false);
    }



}

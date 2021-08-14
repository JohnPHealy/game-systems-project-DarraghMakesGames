using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearNotification : MonoBehaviour
{

    //A simple script placed on notification pop-ups
    //Clears them after a period of time set in the inspector

    [SerializeField] float clearTime;

    void OnEnable()
    {
        StartCoroutine("ClearNotif");
    }

    IEnumerator ClearNotif()
    {
        yield return new WaitForSeconds(clearTime);
        this.gameObject.SetActive(false);

    }



}

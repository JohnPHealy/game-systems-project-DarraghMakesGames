using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearNotification : MonoBehaviour
{

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

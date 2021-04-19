using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnableBuy : MonoBehaviour
{

    [SerializeField] private GameObject buyPrompt;
    [SerializeField] private UnityEvent enableBuyPrompt;
    [SerializeField] private UnityEvent disableBuyPrompt;

    void EnableBuyPrompt()
    {
        enableBuyPrompt.Invoke();
    }

    void DisableBuyPrompt()
    {
        disableBuyPrompt.Invoke();
    }


}

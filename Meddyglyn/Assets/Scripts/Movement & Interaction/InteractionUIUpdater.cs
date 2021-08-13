using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InteractionUIUpdater : MonoBehaviour
{
    public string interactionText;
    private Text readout;
    public string readoutText;

    private void Awake()
    {
        StartCoroutine("UpdateText");
        readout = GetComponent<Text>();
    }

    void Update()
    {
            readout = GetComponent<Text>();
            readout.text = interactionText;
            readoutText = interactionText;
    }

    IEnumerator UpdateText()
    {
        readout = GetComponent<Text>();
        readout.text = interactionText;
        readoutText = interactionText;
        yield return new WaitForSeconds(0.1f);
    }
}

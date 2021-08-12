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
    public string testString;

    private void Awake()
    {
        readout = GetComponent<Text>();
    }

    void Update()
    {
            readout = GetComponent<Text>();
            readout.text = interactionText;
    }
}

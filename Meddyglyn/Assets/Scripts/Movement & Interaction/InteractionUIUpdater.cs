using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionUIUpdater : MonoBehaviour
{
    public string interactionText;
    private TextMesh interactPrompt;
    [SerializeField] GameObject selectionManager;

    private void Start()
    {
        interactPrompt = this.gameObject.GetComponent<TextMesh>();
    }

    void Update()
    {
        interactionText = selectionManager.GetComponent<SelectionManager>().interactText;
        interactPrompt.text = interactionText;
    }
}

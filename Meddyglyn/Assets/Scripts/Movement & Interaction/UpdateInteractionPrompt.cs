using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateInteractionPrompt : MonoBehaviour
{

    [SerializeField] private Transform _selection;
    [SerializeField] private GameObject interactionPrompt;

    public string interactText;
    public bool cooldown = false;

    void Update()
    {

        if (_selection != null)
        {
            //If there is no selection, removes the interaction prompt, clears the "_selection" variable

            interactText = null;
            //reticleRenderer.material.color = Color.white;
            _selection = null;
        }

        var ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2f, Screen.height / 2f, 0f));
        if (Physics.Raycast(ray, out RaycastHit hit, 3f))
        {
            var selection = hit.transform;

            if (selection.CompareTag("Selectable") || selection.CompareTag("Ingredient") || selection.CompareTag("Storage"))
            {
                //If the raycast hits an object matching one of the interactable tags, it stores that as "_selection"
                _selection = selection;
                //The following enables the interaction prompt UI element & updates its text based on the selection
                interactText = _selection.GetComponent<InteractionPrompt>().interactionText;
                interactionPrompt.GetComponent<InteractionUIUpdater>().interactionText = interactText;


            }

        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectionManager : MonoBehaviour
{

    [SerializeField] private Transform _selection;
    [SerializeField] private GameObject interactionPrompt;
    //[SerializeField] private GameObject reticle;
    public string interactText;
    public bool cooldown = false;
    private Image reticleRenderer;

    private void Start()
    {
        //reticleRenderer = reticle.GetComponent<Image>();
    }

    void Update()
    {
        


        if (_selection != null)
        {
            //If there is no selection, removes the interaction prompt, clears the "_selection" variable and resets reticle colour to default

            interactText = null;
            interactionPrompt.SetActive(false);
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
                interactionPrompt.SetActive(true);
                interactText = _selection.GetComponent<InteractionPrompt>().interactionText;
                interactionPrompt.GetComponent<InteractionUIUpdater>().interactionText = interactText;

                //reticleRenderer.material.color = Color.yellow;
            }

        }
        
    }

    //Interaction script - sends message to activate "Interacted" script on highlighted object
    public void Interact()
    {
        if (_selection != null && !cooldown)
        {
            //Debug.Log("Interact");
            _selection.gameObject.SendMessage("Interacted");
            _selection = null;
            cooldown = true;
            StartCoroutine("CooldownTimer");
        }
        else
        {
            Debug.Log("Nothing selected");
        }

    }

    //This cooldown timer prevents "Interact" from firing too quickly
    IEnumerator CooldownTimer()
    {
        yield return new WaitForSeconds(0.5f);
        cooldown = false;
    }
}

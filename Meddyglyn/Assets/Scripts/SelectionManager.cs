using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{

    [SerializeField] private Transform _selection;
    [SerializeField] private GameObject interactionPrompt;

    void Update()
    {

        if (_selection != null)
        {
            interactionPrompt.gameObject.SetActive(false);
            _selection = null;
        }

        var ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2f, Screen.height / 2f, 0f));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 3f))
        {
            var selection = hit.transform;
                if (selection.CompareTag("Selectable") || selection.CompareTag("Ingredient") || selection.CompareTag("Storage"))
            {
                _selection = selection;
                interactionPrompt.gameObject.SetActive(true);
            }

        }
    }

    //Interaction script - sends message to activate "Interacted" script on highlighted object
    public void Interact()
    {
        if (_selection != null)
        {
            //Debug.Log("Interact");
            _selection.gameObject.SendMessage("Interacted");
            _selection = null;
        }
        else
        {
            Debug.Log("Nothing selected");
        }

    }
}

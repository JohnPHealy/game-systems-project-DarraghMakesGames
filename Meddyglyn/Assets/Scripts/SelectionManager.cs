using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{

    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material defaultMaterial;
    [SerializeField] string selectableTag = "Selectable";
    private Transform _selection;




    void Update()
    {

        if (_selection != null)
        {

            //var selectionRenderer = _selection.GetComponent<Renderer>();
            //selectionRenderer.material = defaultMaterial;
            _selection.gameObject.GetComponent<Outline>().enabled = false;

            _selection = null;
        }

        var ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2f, Screen.height / 2f, 0f));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 3f))
        {
            var selection = hit.transform;
                if (selection.CompareTag("Selectable") || selection.CompareTag("Ingredient") || selection.CompareTag("Storage"))
            {
                //hit.collider.gameObject.GetComponent<Outline>().enabled = true;
                //var selectionRenderer = selection.GetComponent<Renderer>();
 
                //if (selectionRenderer != null)
                //{
                //    selectionRenderer.material = highlightMaterial;
//
                //}

                _selection = selection;
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

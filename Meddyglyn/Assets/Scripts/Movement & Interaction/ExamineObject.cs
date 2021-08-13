using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExamineObject : MonoBehaviour
{

    [SerializeField] private Transform _selection;
    [SerializeField] private GameObject carrying;
    [SerializeField] private GameObject examinePopup;
    private Transform carriedObject;
    public bool cooldown = false;

    void Update()
    {
        
        if (_selection != null)
        {
            _selection = null;
        }

        var ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2f, Screen.height / 2f, 0f));
        if (Physics.Raycast(ray, out RaycastHit hit, 3f))
        {
            var selection = hit.transform;
            
            if (selection.CompareTag("Selectable") || selection.CompareTag("Ingredient") || selection.CompareTag("Storage"))
            {
                _selection = selection;
            }

        }
        
    }

    //Examination script - sends message to activate "Examine" script on highlighted object
    public void Examine()
    {

        Debug.Log("Examine");

        //This closes the examination window if it is open
        if (examinePopup.activeSelf && !cooldown)
        {
            examinePopup.SetActive(false);
            cooldown = true;
            StartCoroutine("CooldownTimer");
            
        //If the player is carrying an object, this examines that object
        }
        else if (carrying.transform.childCount > 0 && !cooldown && !examinePopup.activeSelf)
        {
            Debug.Log("Examining held");
            carriedObject = carrying.transform.GetChild(0);
            carriedObject.gameObject.SendMessage("Examine");
            cooldown = true;
            StartCoroutine("CooldownTimer");

        }

        //If the player is not carrying an object, this examines whatever they are looking at
        else if (_selection != null && !cooldown)
        {
            Debug.Log("Examining world");
            _selection.gameObject.SendMessage("Examine");
            _selection = null;
            cooldown = true;
            StartCoroutine("CooldownTimer");
        }

        //If the player is neither carrying an object nor holding anything, nothing happens.
        else
        {
            return;
        }

    }

    //This cooldown timer prevents "Examine" from firing too quickly
    IEnumerator CooldownTimer()
    {
        yield return new WaitForSeconds(0.5f);
        cooldown = false;
    }
}

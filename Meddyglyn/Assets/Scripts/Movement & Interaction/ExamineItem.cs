using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExamineItem : MonoBehaviour
{

    [SerializeField] GameObject examineHolder;
    [SerializeField] GameObject examinePopup;
    [SerializeField] GameObject examinedObject;

    public string uiName;
    public string uiDescription;
    public string uiProperties;

    private void Start()
    {
        examineHolder = GameObject.Find("ExamineHolder");
        examinedObject = this.gameObject;
    }

    public void Examine()
    {
        Debug.Log("Examining item thoroughly");
        examinePopup = examineHolder.transform.GetChild(0).gameObject;
        examinePopup.SetActive(true);
        examinePopup.GetComponent<ExamineUIUpdate>().examinedObject = examinedObject;
    }

}

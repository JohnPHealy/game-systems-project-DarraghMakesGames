using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExamineUIUpdate : MonoBehaviour
{

    public GameObject examinedObject;

    [SerializeField] private GameObject nameObject;
    [SerializeField] private GameObject descriptionObject;
    [SerializeField] private GameObject propertiesObject;

    [SerializeField] private Text nameObjectText;
    [SerializeField] private Text descriptionObjectText;
    [SerializeField] private Text propertiesObjectText;

    public string examinedName;
    public string examinedDescription;
    public string examinedProperties;

    private void Start()
    {
        nameObjectText = nameObject.GetComponent<Text>();
        descriptionObjectText = descriptionObject.GetComponent<Text>();
        propertiesObjectText = propertiesObject.GetComponent<Text>();
    }

    private void Update()
    {
        nameObjectText.text = examinedObject.GetComponent<ExamineItem>().uiName;
        descriptionObjectText.text = examinedObject.GetComponent<ExamineItem>().uiDescription;
        propertiesObjectText.text = examinedObject.GetComponent<ExamineItem>().uiProperties;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExamineItem : MonoBehaviour
{

    [SerializeField] GameObject examinePopup;
    public string testExamine;

    public void Examine()
    {
        Debug.Log("Examining held item thoroughly");
        examinePopup.SetActive(true);
        Debug.Log(testExamine);
    }

}

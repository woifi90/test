using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonNextLevel : MonoBehaviour
{ 

    void Start()
    {
        var input = gameObject.GetComponent<InputField>();
        var se = new InputField.SubmitEvent();
        se.AddListener(SubmitName);
        input.onEndEdit = se;

        //or simply use the line below, 
        //input.onEndEdit.AddListener(SubmitName);  // This also works
    }

    private void SubmitName(string arg0)
    {
        if(arg0 == "Pizza")
        {
            var tex = GameObject.FindGameObjectWithTag("fun").GetComponent<Text>();
            tex.text = "00";

        }
    }
}

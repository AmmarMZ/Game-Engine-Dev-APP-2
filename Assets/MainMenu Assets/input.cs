﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class input : MonoBehaviour
{
    public static string id;
    public InputField mainInputField;    
    void Start()
    {
        mainInputField = GetComponent<InputField>();
        mainInputField.onValueChanged.AddListener(delegate {OnvalueChange(); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnvalueChange() {
        if(mainInputField.text.Length == 3) {
            id = mainInputField.text;
                        Debug.Log(id);

            mainInputField.gameObject.SetActive(false);
        }
    }
}

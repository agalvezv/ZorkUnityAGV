using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zork.Common;
using TMPro;
using System;

public class UnityInputService : MonoBehaviour, IInputService
{

    public event EventHandler<string> InputReceived;


    public TMP_InputField InputField;



    public void ProcessInput()
    {
        InputReceived?.Invoke(this, InputField.text);

    }
    // Start is called before the first frame update
    void Start()
    {
        InputField.Select();
        InputField.ActivateInputField();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

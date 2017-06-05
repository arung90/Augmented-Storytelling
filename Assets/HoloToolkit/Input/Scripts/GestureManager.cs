using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;
using UnityEngine.VR.WSA.Input;

public class GestureManager : MonoBehaviour, IInputClickHandler
{

    // Represents the hologram that is currently being gazed at.
    public GameObject FocusedObject { get; private set; }

    GestureRecognizer recognizer;

    public void OnInputClicked(InputEventData eventData)
    {
        System.Diagnostics.Debug.WriteLine("entering oninputclicked");
        eventData.selectedObject.SendMessage("OnAirTapped", SendMessageOptions.RequireReceiver);
        //throw new NotImplementedException();
    }

    // Use this for initialization
    void Start()
    {
        System.Diagnostics.Debug.WriteLine("Entering Start");
    }

    // Update is called once per frame
    void Update()
    {
        System.Diagnostics.Debug.WriteLine("Entering Update");
    }
}

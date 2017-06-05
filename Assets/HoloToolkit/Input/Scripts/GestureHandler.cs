using HoloToolkit.Unity;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class GestureHandler : Singleton<GestureHandler>
{

    private bool isActive = false;

    // Use this for initialization
    void Start()
    {
        System.Diagnostics.Debug.WriteLine("Entering GestureHandler- Start");
    }

    // Update is called once per frame
    void Update()
    {

        System.Diagnostics.Debug.WriteLine("Entering GestureHandler- Update");
        if (isActive)
        {
            System.Diagnostics.Debug.WriteLine("Entering Update TRUE");
            this.transform.Rotate(0, 1, 0);
        }
    }

    void OnAirTapped()
    {
        System.Diagnostics.Debug.WriteLine("Entering OnAirTapped");
        isActive = !isActive;
    }

}

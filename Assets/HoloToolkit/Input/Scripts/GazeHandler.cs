﻿using HoloToolkit.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeHandler : Singleton<GazeHandler>
{

    private Color startColor;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGazeEnter()
    {
        System.Diagnostics.Debug.WriteLine("Entering OnGazeEnter");
        var com = gameObject.GetComponent<Renderer>();
        startColor = com.material.color;
        com.material.color = Color.yellow;
    }

    void OnGazeExit()
    {
        var com = gameObject.GetComponent<Renderer>();
        com.material.color = startColor;
    }
}

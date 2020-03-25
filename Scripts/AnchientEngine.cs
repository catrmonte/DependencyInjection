using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchientEngine : IEngine
{
    public void StartEngine()
    {
        ActivateCore();
        Debug.Log("Engine started");
    }

    private void ActivateCore()
    {
        Debug.Log("The core has been activated");
    }
}

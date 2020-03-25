using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SolarEngine : IEngine
{
    public void StartEngine()
    {
        UnfoldSolarPanels();
        Debug.Log("Engine started");
    }

    private void UnfoldSolarPanels()
    {
        Debug.Log("The solar panels are unfolded");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotTracker : MonoBehaviour
{
    //static objects
    public GameObject overlay;
    public GameObject seedSelector;
    public string plot1Plant;

    public int plotNumber;
    private void Start()
    {
        plotNumber = 0;
        plot1Plant = "none";
    }
}

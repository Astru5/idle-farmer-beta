using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantSeeds : MonoBehaviour
{
    public GameObject seedIndicator;
    public GameObject seedSelector;
    public GameObject plantCollector;
    public GameObject overlay;
    public GameObject confirmation;
    public GameObject plants;
    PlotTracker plotTracker;
    interactables interactable;

    // Start is called before the first frame update
    void Start()
    {
        seedIndicator.SetActive(true);
        seedSelector.SetActive(false);
        plantCollector.SetActive(false);
        plotTracker = GameObject.FindObjectOfType<PlotTracker>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        interactable = GameObject.FindObjectOfType<interactables>();
        interactable.objects = GameObject.FindGameObjectsWithTag("Interactable");
        plotTracker.plotNumber = 1;
        seedSelector.SetActive(true);
        overlay.SetActive(false);
        confirmation.SetActive(false);
        plants.SetActive(true);
        foreach (GameObject f in interactable.objects)
        {
            f.SetActive(false);
        }
        Time.timeScale = 0;
    }
}

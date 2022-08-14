using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedSelection : MonoBehaviour
{
    PlotTracker plotTracker;
    Plot1Timer plot1timer;
    PlantSeeds plantSeeds;
    Inventory inventory;
    SeedTracker seedTracker;
    public GameObject confirmation;
    public GameObject plants;
    
    private void Start()
    {
        plotTracker = GameObject.FindObjectOfType<PlotTracker>();
        plot1timer = GameObject.FindObjectOfType<Plot1Timer>();
        plantSeeds = GameObject.FindObjectOfType<PlantSeeds>();
        inventory = GameObject.FindObjectOfType<Inventory>();
        seedTracker = GameObject.FindObjectOfType<SeedTracker>();
    }

    public void SelectCabbage() //30 sec wait
    {
        if (plotTracker.plotNumber == 1)
        {
            confirmation.SetActive(true);
            plotTracker.plot1Plant = "cabbage";
            seedTracker.currSeed = "cabbage";
            seedTracker.stop = 0;
            plants.SetActive(false);
        }
    }

    public void SelectCorn() //60 sec wait
    {
        if (plotTracker.plotNumber == 1)
        {
            confirmation.SetActive(true);
            plotTracker.plot1Plant = "corn";
            seedTracker.currSeed = "corn";
            seedTracker.stop = 0;
            plants.SetActive(false);
        }
    }
    public void SelectCucumber() //120 sec wait
    {
        if (plotTracker.plotNumber == 1)
        {
            confirmation.SetActive(true);
            plotTracker.plot1Plant = "cucumber";
            seedTracker.currSeed = "cucumber";
            seedTracker.stop = 0;
            plants.SetActive(false);
        }
    }
    public void SelectCarrot() //300 sec wait
    {
        if (plotTracker.plotNumber == 1)
        {
            confirmation.SetActive(true);
            plotTracker.plot1Plant = "carrot";
            seedTracker.currSeed = "carrot";
            seedTracker.stop = 0;
            plants.SetActive(false);
        }
    }
    public void SelectEggplant() //600 sec wait
    {
        if (plotTracker.plotNumber == 1)
        {
            confirmation.SetActive(true);
            plotTracker.plot1Plant = "eggplant";
            seedTracker.currSeed = "eggplant";
            seedTracker.stop = 0;
            plants.SetActive(false);
        }
    }
    public void SelectPumpkin() //1800 sec wait
    {
        if (plotTracker.plotNumber == 1)
        {
            confirmation.SetActive(true);
            plotTracker.plot1Plant = "pumpkin";
            seedTracker.currSeed = "pumpkin";
            seedTracker.stop = 0;
            plants.SetActive(false);
        }
    }
    public void SelectRadish() //3600 sec wait
    {
        if (plotTracker.plotNumber == 1)
        {
            confirmation.SetActive(true);
            plotTracker.plot1Plant = "radish";
            seedTracker.currSeed = "radish";
            seedTracker.stop = 0;
            plants.SetActive(false);
        }
    }
}

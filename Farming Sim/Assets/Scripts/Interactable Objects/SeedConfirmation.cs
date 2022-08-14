using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeedConfirmation : MonoBehaviour
{
    public Text amount;
    public int number;
    public GameObject confirmation;
    public GameObject P1seedIndicator;
    //public GameObject P2seedIndicator;
    //public GameObject P3seedIndicator;
    //public GameObject P4seedIndicator;

    PlotTracker plotTracker;
    Plot1Timer plot1timer;
    PlantSeeds plantSeeds;
    PlantCollection plantCollection;
    AmountPlanted1 amountPlanted1;
    SeedTracker seedTracker;
    Inventory inventory;
    interactables interactable;

    private void Start()
    {
        plotTracker = GameObject.FindObjectOfType<PlotTracker>();
        plot1timer = GameObject.FindObjectOfType<Plot1Timer>();
        plantSeeds = GameObject.FindObjectOfType<PlantSeeds>();
        amountPlanted1 = GameObject.FindObjectOfType<AmountPlanted1>();
        seedTracker = GameObject.FindObjectOfType<SeedTracker>();
        inventory = GameObject.FindObjectOfType<Inventory>();
        number = 1;
    }

    private void Update()
    {
        amount.text = (number.ToString());
        if(seedTracker.amount>0 && number == 0)
        {
            number = 1;
        }
        if (number > seedTracker.amount)
        {
            number = 1;
        }
        if (seedTracker.amount == 0)
        {
            number = 0;
        }
    }

    public void Plant()
    {
        interactable = GameObject.FindObjectOfType<interactables>();
        amountPlanted1 = GameObject.FindObjectOfType<AmountPlanted1>();
        inventory = GameObject.FindObjectOfType<Inventory>();
        if (number == 0)
        {
            return;
        }
        switch (plotTracker.plotNumber)
        {
            case 1:
                Debug.Log(number);
                switch (plotTracker.plot1Plant)
                {
                    case "cabbage": //30 sec wait
                        plot1timer.plot1timer = 5;
                        plantSeeds.seedIndicator.SetActive(false);
                        plotTracker.seedSelector.SetActive(false);
                        plotTracker.overlay.SetActive(true);
                        inventory.cabbageSeeds -= number;
                        amountPlanted1.amountPlanted = number;
                        break;
                    case "carrot": //60 sec wait
                        plot1timer.plot1timer = 10;
                        plantSeeds.seedIndicator.SetActive(false);
                        plotTracker.seedSelector.SetActive(false);
                        plotTracker.overlay.SetActive(true);
                        inventory.carrotSeeds -= number;
                        amountPlanted1.amountPlanted = number;
                        break;
                    case "corn": //120 sec wait
                        plot1timer.plot1timer = 15;
                        plantSeeds.seedIndicator.SetActive(false);
                        plotTracker.seedSelector.SetActive(false);
                        plotTracker.overlay.SetActive(true);
                        inventory.cornSeeds -= number;
                        amountPlanted1.amountPlanted = number;
                        break;
                    case "cucumber": //300 sec wait
                        plot1timer.plot1timer = 20;
                        plantSeeds.seedIndicator.SetActive(false);
                        plotTracker.seedSelector.SetActive(false);
                        plotTracker.overlay.SetActive(true);
                        inventory.cucumberSeeds -= number;
                        amountPlanted1.amountPlanted = number;
                        break;
                    case "eggplant": //600 sec wait
                        plot1timer.plot1timer = 25;
                        plantSeeds.seedIndicator.SetActive(false);
                        plotTracker.seedSelector.SetActive(false);
                        plotTracker.overlay.SetActive(true);
                        inventory.eggplantSeeds -= number;
                        amountPlanted1.amountPlanted = number;
                        break;
                    case "pumpkin": //1800 sec wait
                        plot1timer.plot1timer = 30;
                        plantSeeds.seedIndicator.SetActive(false);
                        plotTracker.seedSelector.SetActive(false);
                        plotTracker.overlay.SetActive(true);
                        inventory.pumpkinSeeds -= number;
                        amountPlanted1.amountPlanted = number;
                        break;
                    case "radish": //3600 sec wait
                        plot1timer.plot1timer = 35;
                        plantSeeds.seedIndicator.SetActive(false);
                        plotTracker.seedSelector.SetActive(false);
                        plotTracker.overlay.SetActive(true);
                        inventory.radishSeeds -= number;
                        amountPlanted1.amountPlanted = number;
                        break;

                }
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
        }
        foreach (GameObject f in interactable.objects)
        {
            if (f.ToString() != P1seedIndicator.ToString()) //&& f.ToString() != P2seedIndicator.ToString()
            {
                f.SetActive(true);
            }
        }
        Time.timeScale = 1;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlantCollection : MonoBehaviour
{
    public GameObject collector;
    public GameObject indicator;
    public GameObject collectText;
    public int seedsPlanted;
    public int collect;
    public int min;

    PlantIcons1 plantIcons1;
    Sign1Icons sign1Icons;
    Plot1Plants plot1Plants;
    PlotTracker plotTracker;
    PickupText pickupText;
    Inventory inventory;

    private void Start()
    {
        plantIcons1 = GameObject.FindObjectOfType<PlantIcons1>();
        sign1Icons = GameObject.FindObjectOfType<Sign1Icons>();
        plot1Plants = GameObject.FindObjectOfType<Plot1Plants>();
        plotTracker = GameObject.FindObjectOfType<PlotTracker>();
        pickupText = GameObject.FindObjectOfType<PickupText>();
        inventory = GameObject.FindObjectOfType<Inventory>();
    }

    void OnMouseDown()
    {
        plantIcons1.cabbage.SetActive(false);
        plantIcons1.carrot.SetActive(false);
        plantIcons1.corn.SetActive(false);
        plantIcons1.cucumber.SetActive(false);
        plantIcons1.eggplant.SetActive(false);
        plantIcons1.pumpkin.SetActive(false);
        plantIcons1.raddish.SetActive(false);

        sign1Icons.cabbage.SetActive(false);
        sign1Icons.carrot.SetActive(false);
        sign1Icons.corn.SetActive(false);
        sign1Icons.cucumber.SetActive(false);
        sign1Icons.eggplant.SetActive(false);
        sign1Icons.pumpkin.SetActive(false);
        sign1Icons.raddish.SetActive(false);

        if (seedsPlanted % 2 != 0)
        {
            min = ((int)Mathf.Round(seedsPlanted/2))+1;
            Debug.Log("min is: "+min);
        }
        else
        {
            min = seedsPlanted / 2;
            Debug.Log("min is: " + min);
        }
        
        collect = Random.Range(min, ((seedsPlanted * 2)+1));

        collectText.SetActive(true);
        switch (plotTracker.plot1Plant)
        {
            case "cabbage":
                collectText.GetComponent<Text>().text = "+"+collect+" Cabbage";
                inventory.cabbagePlants += collect;
                break;
            case "carrot":
                collectText.GetComponent<Text>().text = "+" + collect + " Carrot";
                inventory.carrotPlants += collect;
                break;
            case "corn":
                collectText.GetComponent<Text>().text = "+" + collect + " Corn";
                inventory.cornPlants += collect;
                break;
            case "cucumber":
                collectText.GetComponent<Text>().text = "+" + collect + " Cucumber";
                inventory.cucumberPlants += collect;
                break;
            case "eggplant":
                collectText.GetComponent<Text>().text = "+" + collect + " Eggplant";
                inventory.eggplantPlants += collect;
                break;
            case "pumpkin":
                collectText.GetComponent<Text>().text = "+" + collect + " Pumpkin";
                inventory.pumpkinPlants += collect;
                break;
            case "radish":
                collectText.GetComponent<Text>().text = "+" + collect + " Radish";
                inventory.radishPlants += collect;
                break;
            default:
                Debug.LogWarning("Error: could not find case");
            break;
        }

        StartCoroutine(RemoveText());

        foreach (GameObject f in plot1Plants.plants1)
        {
            f.SetActive(false);
        }

        indicator.SetActive(true);
    }

    IEnumerator RemoveText()
    {
        yield return new WaitForSeconds(2);
        collectText.SetActive(false);
        collector.SetActive(false);
    }
}

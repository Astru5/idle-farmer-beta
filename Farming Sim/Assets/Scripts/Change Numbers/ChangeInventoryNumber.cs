using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeInventoryNumber : MonoBehaviour
{
    Inventory inventory;

    public Text cabbageSeeds;
    public Text cornSeeds;
    public Text cucumberSeeds;
    public Text carrotSeeds;
    public Text eggplantSeeds;
    public Text pumpkinSeeds;
    public Text radishSeeds;

    public Text cabbagePlants;
    public Text cornPlants;
    public Text cucumberPlants;
    public Text carrotplants;
    public Text eggplantPlants;
    public Text pumpkinPlants;
    public Text radishPlants;

    public Text test;

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindObjectOfType<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        cabbageSeeds.text = (inventory.cabbageSeeds.ToString());
        cornSeeds.text = (inventory.cornSeeds.ToString());
        cucumberSeeds.text = (inventory.cucumberSeeds.ToString());
        carrotSeeds.text = (inventory.carrotSeeds.ToString());
        eggplantSeeds.text = (inventory.eggplantSeeds.ToString());
        pumpkinSeeds.text = (inventory.pumpkinSeeds.ToString());
        radishSeeds.text = (inventory.radishSeeds.ToString());

        cabbagePlants.text = inventory.cabbagePlants.ToString();
        cornPlants.text = inventory.cornPlants.ToString();
        cucumberPlants.text = inventory.cucumberPlants.ToString();
        carrotplants.text = inventory.carrotPlants.ToString();
        eggplantPlants.text = inventory.eggplantPlants.ToString();
        pumpkinPlants.text = inventory.pumpkinPlants.ToString();
        radishPlants.text = inventory.radishPlants.ToString();

    }
}

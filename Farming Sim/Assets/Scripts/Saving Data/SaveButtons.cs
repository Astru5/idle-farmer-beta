using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveButtons : MonoBehaviour
{
    Inventory inventory;

    public void SaveInventory()
    {
        inventory = GameObject.FindObjectOfType<Inventory>();
        SaveSystem.SaveInventory(inventory);
    }

    public void LoadInventory()
    {
        inventory = GameObject.FindObjectOfType<Inventory>();
        PlayerData data = SaveSystem.LoadData();

        inventory.money = data.money;

        inventory.cabbageSeeds = data.cabbageSeeds;
        inventory.carrotSeeds = data.carrotSeeds;
        inventory.cornSeeds = data.cornSeeds;
        inventory.cucumberSeeds = data.cucumberSeeds;
        inventory.eggplantSeeds = data.eggplantSeeds;
        inventory.pumpkinSeeds = data.pumpkinSeeds;
        inventory.radishSeeds = data.radishSeeds;

        inventory.cabbagePlants = data.cabbagePlants;
        inventory.carrotPlants = data.carrotPlants;
        inventory.cornPlants = data.cornPlants;
        inventory.cucumberPlants = data.cucumberPlants;
        inventory.eggplantPlants = data.eggplantPlants;
        inventory.pumpkinPlants = data.pumpkinPlants;
        inventory.radishPlants = data.radishPlants;
    }
}

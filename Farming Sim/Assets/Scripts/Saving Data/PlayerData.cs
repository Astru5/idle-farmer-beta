using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int money;

    public int cabbageSeeds;
    public int carrotSeeds;
    public int cornSeeds;
    public int cucumberSeeds;
    public int eggplantSeeds;
    public int pumpkinSeeds;
    public int radishSeeds;

    public int cabbagePlants;
    public int carrotPlants;
    public int cornPlants;
    public int cucumberPlants;
    public int eggplantPlants;
    public int pumpkinPlants;
    public int radishPlants;

    public PlayerData (Inventory inventory)
    {
        money = inventory.money;

        cabbageSeeds = inventory.cabbagePlants;
        carrotPlants = inventory.carrotPlants;
        cornPlants = inventory.cornPlants;
        cucumberPlants = inventory.cucumberPlants;
        eggplantPlants = inventory.eggplantPlants;
        pumpkinPlants = inventory.pumpkinPlants;
        radishPlants = inventory.radishPlants;

        cabbageSeeds = inventory.cabbageSeeds;
        carrotSeeds = inventory.carrotSeeds;
        cornSeeds = inventory.cornSeeds;
        cucumberSeeds = inventory.cucumberSeeds;
        eggplantSeeds = inventory.eggplantSeeds;
        pumpkinSeeds = inventory.pumpkinSeeds;
        radishSeeds = inventory.radishSeeds;
    }

    /*
    string time = System.DateTime.UtcNow.ToLocalTime().ToString("HH:mm:ss");
    string date = System.DateTime.Now.ToString("MM/dd/yyyy");
    print(time);
    print(date);
    */
}

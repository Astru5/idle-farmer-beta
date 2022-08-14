using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedTracker : MonoBehaviour
{
    Inventory inventory;
    public string currSeed;
    SeedConfirmationNumber seedConfirmationNumber;
    public GameObject seedConfirmation;
    public int stop = 0;
    public int amount;

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindObjectOfType<Inventory>();
    }

    private void Update()
    {
        if (seedConfirmation.active && stop==0)
        {
            seedConfirmationNumber = GameObject.FindObjectOfType<SeedConfirmationNumber>();
            switch (currSeed)
            {
                case "cabbage":
                    amount = inventory.cabbageSeeds;
                    break;
                case "corn":
                    amount = inventory.cornSeeds;
                    break;
                case "cucumber":
                    amount = inventory.cucumberSeeds;
                    break;
                case "carrot":
                    amount = inventory.carrotSeeds;
                    break;
                case "eggplant":
                    amount = inventory.eggplantSeeds;
                    break;
                case "pumpkin":
                    amount = inventory.pumpkinSeeds;
                    break;
                case "radish":
                    amount = inventory.radishSeeds;
                    break;
            }
            stop = 1;
        }
    }
}

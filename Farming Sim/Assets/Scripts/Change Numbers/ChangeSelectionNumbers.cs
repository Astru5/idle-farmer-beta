using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSelectionNumbers : MonoBehaviour
{
    Inventory inventory;

    public Text cabbageSeeds;
    public Text cornSeeds;
    public Text cucumberSeeds;
    public Text carrotSeeds;
    public Text eggplantSeeds;
    public Text pumpkinSeeds;
    public Text radishSeeds;

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
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlantAmount : MonoBehaviour
{
    Inventory inventory;

    public Text cabbagePlants;
    public Text cornPlants;
    public Text cucumberPlants;
    public Text carrotPlants;
    public Text eggplantPlants;
    public Text pumpkinPlants;
    public Text radishPlants;

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindObjectOfType<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        cabbagePlants.text = inventory.cabbagePlants.ToString();
        cornPlants.text = inventory.cornPlants.ToString();
        cucumberPlants.text = inventory.cucumberPlants.ToString();
        carrotPlants.text = inventory.carrotPlants.ToString();
        eggplantPlants.text = inventory.eggplantPlants.ToString();
        pumpkinPlants.text = inventory.pumpkinPlants.ToString();
        radishPlants.text = inventory.radishPlants.ToString();
    }
}

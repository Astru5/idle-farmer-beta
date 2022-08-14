using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmountPlanted1 : MonoBehaviour
{
    public int amountPlanted;
    PlantCollection plantCollection;
    public GameObject collector;
    public GameObject confirmSeed;

    private void Update()
    {
        if (amountPlanted>0 && collector.active)
        {
            Debug.Log("amount planted: "+amountPlanted);
            plantCollection = GameObject.FindObjectOfType<PlantCollection>();
            plantCollection.seedsPlanted = amountPlanted;
            amountPlanted = 0;
        }
    }
}

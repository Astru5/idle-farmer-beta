using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInventory : MonoBehaviour
{
    Inventory inventory;
    private void Start()
    {
        SaveInventory();
    }
    public void SaveInventory()
    {
        Debug.Log("Inventory loaded");
        inventory = GameObject.FindObjectOfType<Inventory>();
        SaveSystem.SaveInventory(inventory);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellShop : MonoBehaviour
{
    public GameObject sellConfirm;
    public GameObject sell;
    public GameObject confirmText;
    public GameObject sellNumberText;
    
    public int sellNumber;
    //public int maxPlants;

    GoToShop goToShop;
    Inventory inventory;
    Plot1Timer plot1Timer;
    SellConfirmText sellConfirmText;

    // Start is called before the first frame update
    void Start()
    {
        goToShop = GameObject.FindObjectOfType<GoToShop>();
        if (sell.active)
        {
            sellConfirm.SetActive(false);
        }
    }

    private void Update()
    {
        //Debug.Log();
        sellNumberText.GetComponent<Text>().text = (sellNumber.ToString());
        if (goToShop.maxPlants > 0 && sellNumber == 0)
        {
            sellNumber = 1;
        }
        if (sellNumber > goToShop.maxPlants)
        {
            sellNumber = 1;
        }
        if (goToShop.maxPlants == 0)
        {
            sellNumber = 0;
        }
    }

    public void SellCabage()
    {
        goToShop = GameObject.FindObjectOfType<GoToShop>();
        inventory = GameObject.FindObjectOfType<Inventory>();
        goToShop.maxPlants = inventory.cabbagePlants;
        goToShop.sellPlant = "cabage";
        confirmText.GetComponent<Text>().text = ("How Many " + goToShop.sellPlant + " Would You Like to Sell?");
        sellConfirm.SetActive(true);
        sell.SetActive(false);
    }
    public void SellCarrot()
    {
        goToShop = GameObject.FindObjectOfType<GoToShop>();
        inventory = GameObject.FindObjectOfType<Inventory>();
        goToShop.maxPlants = inventory.carrotPlants;
        goToShop.sellPlant = "carrot";
        confirmText.GetComponent<Text>().text = ("How Many " + goToShop.sellPlant + " Would You Like to Sell?");
        sellConfirm.SetActive(true);
        sell.SetActive(false);
    }
    public void SellCorn()
    {
        goToShop = GameObject.FindObjectOfType<GoToShop>();
        inventory = GameObject.FindObjectOfType<Inventory>();
        goToShop.maxPlants = inventory.cornPlants;
        goToShop.sellPlant = "corn";
        confirmText.GetComponent<Text>().text = ("How Many " + goToShop.sellPlant + " Would You Like to Sell?");
        sellConfirm.SetActive(true);
        sell.SetActive(false);
    }
    public void SellCucumber()
    {
        goToShop = GameObject.FindObjectOfType<GoToShop>();
        inventory = GameObject.FindObjectOfType<Inventory>();
        goToShop.maxPlants = inventory.cucumberPlants;
        goToShop.sellPlant = "cucumber";
        confirmText.GetComponent<Text>().text = ("How Many " + goToShop.sellPlant + " Would You Like to Sell?");
        sellConfirm.SetActive(true);
        sell.SetActive(false);
    }
    public void SellEggplant()
    {
        goToShop = GameObject.FindObjectOfType<GoToShop>();
        inventory = GameObject.FindObjectOfType<Inventory>();
        goToShop.maxPlants = inventory.eggplantPlants;
        goToShop.sellPlant = "eggplant";
        confirmText.GetComponent<Text>().text = ("How Many " + goToShop.sellPlant + " Would You Like to Sell?");
        sellConfirm.SetActive(true);
        sell.SetActive(false);
    }
    public void SellPumpkin()
    {
        goToShop = GameObject.FindObjectOfType<GoToShop>();
        inventory = GameObject.FindObjectOfType<Inventory>();
        goToShop.maxPlants = inventory.pumpkinPlants;
        goToShop.sellPlant = "pumpkin";
        confirmText.GetComponent<Text>().text = ("How Many " + goToShop.sellPlant + " Would You Like to Sell?");
        sellConfirm.SetActive(true);
        sell.SetActive(false);
    }
    public void SellRadish()
    {
        goToShop = GameObject.FindObjectOfType<GoToShop>();
        inventory = GameObject.FindObjectOfType<Inventory>();
        goToShop.maxPlants = inventory.radishPlants;
        goToShop.sellPlant = "radish";
        confirmText.GetComponent<Text>().text = ("How Many " + goToShop.sellPlant + " Would You Like to Sell?");
        sellConfirm.SetActive(true);
        sell.SetActive(false);
    }
    public void CancelSell()
    {
        sellConfirm.SetActive(false);
        sell.SetActive(true);
    }
    public void ConfirmSell()
    {
        sellConfirmText = GameObject.FindObjectOfType<SellConfirmText>();
        inventory = GameObject.FindObjectOfType<Inventory>();
        goToShop = GameObject.FindObjectOfType<GoToShop>();
        if (sellNumber == 0)
        {
            return;
        }
        switch (goToShop.sellPlant)
        {
            case "cabage":
                inventory.cabbagePlants -= sellNumber;
                inventory.money += (sellNumber * 1);
                sellConfirmText.sold = true;
                sellConfirmText.soldNum = sellNumber;
                sellConfirmText.money = sellNumber * 1;
                sellConfirmText.plant = "Cabage";
                break;
            case "carrot":
                inventory.carrotPlants -= sellNumber;
                inventory.money += (sellNumber * 5);
                sellConfirmText.sold = true;
                sellConfirmText.soldNum = sellNumber;
                sellConfirmText.money = sellNumber * 5;
                sellConfirmText.plant = "Carrot";
                break;
            case "corn":
                inventory.cornPlants -= sellNumber;
                inventory.money += (sellNumber * 10);
                sellConfirmText.sold = true;
                sellConfirmText.soldNum = sellNumber;
                sellConfirmText.money = sellNumber * 10;
                sellConfirmText.plant = "Corn";
                break;
            case "cucumber":
                inventory.cucumberPlants -= sellNumber;
                inventory.money += (sellNumber * 50);
                sellConfirmText.sold = true;
                sellConfirmText.soldNum = sellNumber;
                sellConfirmText.money = sellNumber * 50;
                sellConfirmText.plant = "Cucumber";
                break;
            case "eggplant":
                inventory.eggplantPlants -= sellNumber;
                inventory.money += (sellNumber * 100);
                sellConfirmText.sold = true;
                sellConfirmText.soldNum = sellNumber;
                sellConfirmText.money = sellNumber * 100;
                sellConfirmText.plant = "Eggplant";
                break;
            case "pumpkin":
                inventory.pumpkinPlants -= sellNumber;
                inventory.money += (sellNumber * 250);
                sellConfirmText.sold = true;
                sellConfirmText.soldNum = sellNumber;
                sellConfirmText.money = sellNumber * 250;
                sellConfirmText.plant = "Pumpkin";
                break;
            case "radish":
                inventory.radishPlants -= sellNumber;
                inventory.money += (sellNumber * 1000);
                sellConfirmText.sold = true;
                sellConfirmText.soldNum = sellNumber;
                sellConfirmText.money = sellNumber * 1000;
                sellConfirmText.plant = "Radish";
                break;
        }
        sellConfirm.SetActive(false);
        sell.SetActive(true);
    }
}
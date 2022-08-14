using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellConfirm : MonoBehaviour
{
    GoToShop goToShop;
    Inventory inventory;
    SellShop sellShop;
    public int maxPlants;

    public void MinusTen()
    {
        sellShop = GameObject.FindObjectOfType<SellShop>();
        if (sellShop.sellNumber > 10)
        {
            sellShop.sellNumber -= 10;
        }
    }
    public void MinusFive()
    {
        sellShop = GameObject.FindObjectOfType<SellShop>();
        if (sellShop.sellNumber > 5)
        {
            sellShop.sellNumber -= 5;
        }
    }
    public void MinusOne()
    {
        sellShop = GameObject.FindObjectOfType<SellShop>();
        if (sellShop.sellNumber > 1)
        {
            sellShop.sellNumber -= 1;
        }
    }
    public void PlusOne()
    {
        sellShop = GameObject.FindObjectOfType<SellShop>();
        goToShop = GameObject.FindObjectOfType<GoToShop>();
        maxPlants = goToShop.maxPlants;
        if (sellShop.sellNumber < maxPlants)
        {
            sellShop.sellNumber += 1;
        }
    }
    public void PlusFive()
    {
        sellShop = GameObject.FindObjectOfType<SellShop>();
        goToShop = GameObject.FindObjectOfType<GoToShop>();
        maxPlants = goToShop.maxPlants;
        if (sellShop.sellNumber < maxPlants - 4)
        {
            sellShop.sellNumber += 5;
        }
        else
        {
            sellShop.sellNumber = maxPlants;
        }
    }
    public void PlusTen()
    {
        sellShop = GameObject.FindObjectOfType<SellShop>();
        goToShop = GameObject.FindObjectOfType<GoToShop>();
        maxPlants = goToShop.maxPlants;
        if (sellShop.sellNumber < maxPlants - 9)
        {
            sellShop.sellNumber += 10;
        }
        else
        {
            sellShop.sellNumber = maxPlants;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopSeeds : MonoBehaviour
{
    Inventory inventory;
    public int price;
    public GameObject TooBroke;
    Plot1Timer plot1Timer;
    public GameObject purchaseBG;
    public GameObject purchaseText;

    private void Start()
    {
        TooBroke.SetActive(false);
        purchaseText.SetActive(false);
        purchaseBG.SetActive(false);
    }

    public void BuyCabage()
    {
        price = 10;
        plot1Timer = GameObject.FindObjectOfType<Plot1Timer>();
        inventory = GameObject.FindObjectOfType<Inventory>();
        if (inventory.money >= price)
        {
            if (purchaseBG.active || TooBroke.active)
            {
                return;
            }
            else
            {
                inventory.cabbageSeeds += 50;
                inventory.money -= price;
                purchaseText.GetComponent<Text>().text = ("Purchased 1 Pack of Cabage Seeds");
                purchaseBG.SetActive(true);
                purchaseText.SetActive(true);
                plot1Timer.countDown = 1;
                Time.timeScale = 1;
                StartCoroutine(DeleteConfirmText());
            }
        }
        else
        {
            if (TooBroke.active || purchaseBG.active)
            {
                return;
            }
            else
            {
                TooBroke.SetActive(true);
                plot1Timer.countDown = 1;
                Time.timeScale = 1;
                StartCoroutine(DeleteBrokeText());
            }
            
        }
    }
    public void BuyCarrots()
    {
        price = 50;
        plot1Timer = GameObject.FindObjectOfType<Plot1Timer>();
        inventory = GameObject.FindObjectOfType<Inventory>();
        if (inventory.money >= price)
        {
            if (purchaseBG.active || TooBroke.active)
            {
                return;
            }
            else
            {
                inventory.carrotSeeds += 50;
                inventory.money -= price;
                purchaseText.GetComponent<Text>().text = ("Purchased 1 Pack of Carrot Seeds");
                purchaseBG.SetActive(true);
                purchaseText.SetActive(true);
                plot1Timer.countDown = 1;
                Time.timeScale = 1;
                StartCoroutine(DeleteConfirmText());
            }
        }
        else
        {
            if (TooBroke.active || purchaseBG.active)
            {
                return;
            }
            else
            {
                TooBroke.SetActive(true);
                plot1Timer.countDown = 1;
                Time.timeScale = 1;
                StartCoroutine(DeleteBrokeText());
            }
        }
    }
    public void BuyCorn()
    {
        price = 100;
        plot1Timer = GameObject.FindObjectOfType<Plot1Timer>();
        inventory = GameObject.FindObjectOfType<Inventory>();
        if (inventory.money >= price)
        {
            if (purchaseBG.active || TooBroke.active)
            {
                return;
            }
            else
            {
                inventory.cornSeeds += 50;
                inventory.money -= price;
                purchaseText.GetComponent<Text>().text = ("Purchased 1 Pack of Corn Seeds");
                purchaseBG.SetActive(true);
                purchaseText.SetActive(true);
                plot1Timer.countDown = 1;
                Time.timeScale = 1;
                StartCoroutine(DeleteConfirmText());
            }
        }
        else
        {
            if (TooBroke.active || purchaseBG.active)
            {
                return;
            }
            else
            {
                TooBroke.SetActive(true);
                plot1Timer.countDown = 1;
                Time.timeScale = 1;
                StartCoroutine(DeleteBrokeText());
            }
        }
    }
    public void BuyCucumber()
    {
        price = 500;
        plot1Timer = GameObject.FindObjectOfType<Plot1Timer>();
        inventory = GameObject.FindObjectOfType<Inventory>();
        if (inventory.money >= price)
        {
            if (purchaseBG.active || TooBroke.active)
            {
                return;
            }
            else
            {
                inventory.cucumberSeeds += 50;
                inventory.money -= price;
                purchaseText.GetComponent<Text>().text = ("Purchased 1 Pack of Cucumber Seeds");
                purchaseBG.SetActive(true);
                purchaseText.SetActive(true);
                plot1Timer.countDown = 1;
                Time.timeScale = 1;
                StartCoroutine(DeleteConfirmText());
            }
        }
        else
        {
            if (TooBroke.active || purchaseBG.active)
            {
                return;
            }
            else
            {
                TooBroke.SetActive(true);
                plot1Timer.countDown = 1;
                Time.timeScale = 1;
                StartCoroutine(DeleteBrokeText());
            }
        }
    }
    public void BuyEggplant()
    {
        price = 1000;
        plot1Timer = GameObject.FindObjectOfType<Plot1Timer>();
        inventory = GameObject.FindObjectOfType<Inventory>();
        if (inventory.money >= price)
        {
            if (purchaseBG.active || TooBroke.active)
            {
                return;
            }
            else
            {
                inventory.eggplantSeeds += 50;
                inventory.money -= price;
                purchaseText.GetComponent<Text>().text = ("Purchased 1 Pack of Eggplant Seeds");
                purchaseBG.SetActive(true);
                purchaseText.SetActive(true);
                plot1Timer.countDown = 1;
                Time.timeScale = 1;
                StartCoroutine(DeleteConfirmText());
            }
        }
        else
        {
            if (TooBroke.active || purchaseBG.active)
            {
                return;
            }
            else
            {
                TooBroke.SetActive(true);
                plot1Timer.countDown = 1;
                Time.timeScale = 1;
                StartCoroutine(DeleteBrokeText());
            }
        }
    }
    public void BuyPumpkin()
    {
        price = 5000;
        plot1Timer = GameObject.FindObjectOfType<Plot1Timer>();
        inventory = GameObject.FindObjectOfType<Inventory>();
        if (inventory.money >= price)
        {
            if (purchaseBG.active || TooBroke.active)
            {
                return;
            }
            else
            {
                inventory.pumpkinSeeds += 50;
                inventory.money -= price;
                purchaseText.GetComponent<Text>().text = ("Purchased 1 Pack of Pumpkin Seeds");
                purchaseBG.SetActive(true);
                purchaseText.SetActive(true);
                plot1Timer.countDown = 1;
                Time.timeScale = 1;
                StartCoroutine(DeleteConfirmText());
            }
        }
        else
        {
            if (TooBroke.active || purchaseBG.active)
            {
                return;
            }
            else
            {
                TooBroke.SetActive(true);
                plot1Timer.countDown = 1;
                Time.timeScale = 1;
                StartCoroutine(DeleteBrokeText());
            }
        }
    }
    public void BuyRaddish()
    {
        price = 50000;
        plot1Timer = GameObject.FindObjectOfType<Plot1Timer>();
        inventory = GameObject.FindObjectOfType<Inventory>();
        if (inventory.money >= price)
        {
            if (purchaseBG.active || TooBroke.active)
            {
                return;
            }
            else
            {
                inventory.radishSeeds += 50;
                inventory.money -= price;
                purchaseText.GetComponent<Text>().text = ("Purchased 1 Pack of Radish Seeds");
                purchaseBG.SetActive(true);
                purchaseText.SetActive(true);
                plot1Timer.countDown = 1;
                Time.timeScale = 1;
                StartCoroutine(DeleteConfirmText());
            }
        }
        else
        {
            if (TooBroke.active || purchaseBG.active)
            {
                return;
            }
            else
            {
                TooBroke.SetActive(true);
                plot1Timer.countDown = 1;
                Time.timeScale = 1;
                StartCoroutine(DeleteBrokeText());
            }
        }
    }

    IEnumerator DeleteBrokeText()
    {
        yield return new WaitForSeconds(1);
        Time.timeScale = 0;
        plot1Timer.countDown = 0;
        TooBroke.SetActive(false);
    }
    IEnumerator DeleteConfirmText()
    {
        yield return new WaitForSeconds(2);
        Time.timeScale = 0;
        plot1Timer.countDown = 0;
        purchaseBG.SetActive(false);
        purchaseText.SetActive(false);
    }
}


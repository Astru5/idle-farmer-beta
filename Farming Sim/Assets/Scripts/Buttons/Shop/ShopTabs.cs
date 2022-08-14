using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopTabs : MonoBehaviour
{
    public GameObject seeds;
    public GameObject sell;
    public GameObject upgrades;
    ShopSeeds shopSeeds;

    public void SeedsTab()
    {
        seeds.SetActive(true);
        sell.SetActive(false);
        upgrades.SetActive(false);
    }
    public void SellTab()
    {
        if (seeds.active)
        {
            shopSeeds = GameObject.FindObjectOfType<ShopSeeds>();
            shopSeeds.TooBroke.SetActive(false);
            shopSeeds.purchaseBG.SetActive(false);
            shopSeeds.purchaseText.SetActive(false);
        }
        seeds.SetActive(false);
        sell.SetActive(true);
        upgrades.SetActive(false);
    }
    public void UpgradesTab()
    {
        if (seeds.active)
        {
            shopSeeds = GameObject.FindObjectOfType<ShopSeeds>();
            shopSeeds.TooBroke.SetActive(false);
            shopSeeds.purchaseBG.SetActive(false);
            shopSeeds.purchaseText.SetActive(false);
        }
        seeds.SetActive(false);
        sell.SetActive(false);
        upgrades.SetActive(true);
    }
}

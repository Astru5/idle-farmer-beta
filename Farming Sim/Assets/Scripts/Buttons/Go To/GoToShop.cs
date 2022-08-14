using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToShop : MonoBehaviour
{
    public GameObject shop;
    public GameObject overlay;
    public GameObject seeds;
    public GameObject sell;
    public GameObject upgrades;

    public string sellPlant;
    public int maxPlants;

    interactables interactable;
    ShopSeeds shopSeeds;
    Plot1Timer plot1Timer;

    // Start is called before the first frame update
    void Start()
    {
        shop.SetActive(false);
    }

    private void Update()
    {
        //Debug.Log(maxPlants);
    }

    void OnMouseDown()
    {
        Time.timeScale = 0;
        interactable = GameObject.FindObjectOfType<interactables>();
        interactable.objects = GameObject.FindGameObjectsWithTag("Interactable");
        shop.SetActive(true);
        overlay.SetActive(false);
        seeds.SetActive(true);
        sell.SetActive(false);
        upgrades.SetActive(false);
        foreach (GameObject f in interactable.objects)
        {
            f.SetActive(false);
        }
    }

    public void LeaveShop()
    {
        if (seeds.active)
        {
            shopSeeds = GameObject.FindObjectOfType<ShopSeeds>();
            shopSeeds.TooBroke.SetActive(false);
            shopSeeds.purchaseBG.SetActive(false);
            shopSeeds.purchaseText.SetActive(false);
        }
        plot1Timer = GameObject.FindObjectOfType<Plot1Timer>();
        plot1Timer.countDown = 0;
        interactable = GameObject.FindObjectOfType<interactables>();
        shop.SetActive(false);
        overlay.SetActive(true);
        foreach (GameObject f in interactable.objects)
        {
            f.SetActive(true);
        }
        Time.timeScale = 1;
    }
}

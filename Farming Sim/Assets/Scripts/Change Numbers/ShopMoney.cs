using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopMoney : MonoBehaviour
{
    Inventory inventory;
    public Text moneyDisplay;
    public GameObject soldText;
    public GameObject soldBG;
    public GameObject sellTab;

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindObjectOfType<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        moneyDisplay.text = (inventory.money.ToString());
        if (!sellTab.active)
        {
            soldText.SetActive(false);
            soldBG.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMoney : MonoBehaviour
{
    Inventory inventory;
    public GameObject moneyDisplay;

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindObjectOfType<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        moneyDisplay.GetComponent<Text>().text = (""+inventory.money.ToString());
    }
}

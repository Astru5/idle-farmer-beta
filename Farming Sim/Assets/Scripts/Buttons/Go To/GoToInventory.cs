using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToInventory : MonoBehaviour
{
    public GameObject inventory;
    public GameObject overlay;
    interactables interactable;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ToInventory()
    {
        Time.timeScale = 0;
        interactable = GameObject.FindObjectOfType<interactables>();
        interactable.objects = GameObject.FindGameObjectsWithTag("Interactable");
        inventory.SetActive(true);
        overlay.SetActive(false);
        foreach (GameObject f in interactable.objects)
        {
            f.SetActive(false);
        }
    }

    public void LeaveInventory()
    {
        interactable = GameObject.FindObjectOfType<interactables>();
        inventory.SetActive(false);
        overlay.SetActive(true);
        foreach (GameObject f in interactable.objects)
        {
            f.SetActive(true);
        }
        Time.timeScale = 1;
    }
}

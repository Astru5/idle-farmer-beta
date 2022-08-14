using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideUI : MonoBehaviour
{
    public GameObject inventory;
    public GameObject settings;

    // Start is called before the first frame update
    void Start()
    {
        inventory.SetActive(false);
        settings.SetActive(false);
    }
}

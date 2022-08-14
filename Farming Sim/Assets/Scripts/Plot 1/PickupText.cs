using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupText : MonoBehaviour
{
    public GameObject collectText;

    // Start is called before the first frame update
    void Start()
    {
        collectText.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plot1Plants : MonoBehaviour
{
    public GameObject[] plants1;

    // Start is called before the first frame update
    void Start()
    {
        plants1 = GameObject.FindGameObjectsWithTag("Plot1Plants");
        foreach (GameObject f in plants1)
        {
            f.SetActive(false);
        }
    }
}

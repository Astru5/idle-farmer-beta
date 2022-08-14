using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sign1Icons : MonoBehaviour
{
    public GameObject cabbage;
    public GameObject corn;
    public GameObject cucumber;
    public GameObject carrot;
    public GameObject eggplant;
    public GameObject pumpkin;
    public GameObject raddish;

    // Start is called before the first frame update
    void Start()
    {
        cabbage.SetActive(false);
        corn.SetActive(false);
        cucumber.SetActive(false);
        carrot.SetActive(false);
        eggplant.SetActive(false);
        pumpkin.SetActive(false);
        raddish.SetActive(false);
    }
}

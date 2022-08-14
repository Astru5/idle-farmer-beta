using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyPlot : MonoBehaviour
{
    public GameObject comingSoon;
    private void Start()
    {
        comingSoon.SetActive(false);
    }

    private void OnMouseDown()
    {
        comingSoon.SetActive(true);
        comingSoon.GetComponent<Text>().text = "Coming Soon";

        StartCoroutine(deleteText());
    }

    IEnumerator deleteText()
    {
        yield return new WaitForSeconds(1);
        comingSoon.SetActive(false);
    }
}

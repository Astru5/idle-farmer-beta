using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour
{
    public GameObject boatText;

    private void Start()
    {
        boatText.SetActive(false);
    }
    private void OnMouseDown()
    {
        if (boatText.active)
        {
            return;
        }
        boatText.SetActive(true);
        StartCoroutine(DeleteText());
    }
    IEnumerator DeleteText()
    {
        yield return new WaitForSeconds(2);
        boatText.SetActive(false);
    }
}

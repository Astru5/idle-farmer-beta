using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheBarn : MonoBehaviour
{
    public GameObject comingSoon;
    private void Start()
    {
        comingSoon.SetActive(false);
    }

    public void GoToBarn()
    {
        comingSoon.SetActive(true);
        StartCoroutine(DeleteText());
    }

    IEnumerator DeleteText()
    {
        yield return new WaitForSeconds(2);
        comingSoon.SetActive(false);
    }
}

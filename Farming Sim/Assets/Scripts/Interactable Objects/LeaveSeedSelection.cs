using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveSeedSelection : MonoBehaviour
{
    public GameObject seedSelection;
    public GameObject overlay;
    interactables interactable;

    public void LeaveSeeds()
    {
        interactable = GameObject.FindObjectOfType<interactables>();
        seedSelection.SetActive(false);
        overlay.SetActive(true);
        foreach (GameObject f in interactable.objects)
        {
            f.SetActive(true);
        }
        Time.timeScale = 1;
    }
}

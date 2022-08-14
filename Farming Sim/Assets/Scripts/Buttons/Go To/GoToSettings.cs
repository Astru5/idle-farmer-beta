using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToSettings : MonoBehaviour
{
    public GameObject settings;
    public GameObject overlay;
    interactables interactable;
    Plot1Timer plot1Timer;

    private void Start()
    {

    }

    public void IngameSettings()
    {
        Time.timeScale = 0;
        plot1Timer = GameObject.FindObjectOfType<Plot1Timer>();
        plot1Timer.countDown = 1;
        interactable = GameObject.FindObjectOfType<interactables>();
        interactable.objects = GameObject.FindGameObjectsWithTag("Interactable");
        settings.SetActive(true);
        overlay.SetActive(false);
        foreach (GameObject f in interactable.objects)
        {
            f.SetActive(false);
        }
    }
    public void LeaveSettings()
    {
        interactable = GameObject.FindObjectOfType<interactables>();
        plot1Timer = GameObject.FindObjectOfType<Plot1Timer>();
        plot1Timer.countDown = 0;
        settings.SetActive(false);
        overlay.SetActive(true);
        foreach (GameObject f in interactable.objects)
        {
            f.SetActive(true);
        }
        Time.timeScale = 1;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plot1Timer : MonoBehaviour
{
    public float plot1timer;
    PlantSeeds plantSeeds;
    PlotTracker plotTracker;
    PlantIcons1 plantIcons1;
    Sign1Icons sign1Icons;
    Plot1Plants plot1Plants;
    public GameObject collect;
    public GameObject collectText;
    public GameObject timerText;
    public GameObject timerBG;
    public int countDown;

    // Start is called before the first frame update
    void Start()
    {
        plantSeeds = GameObject.FindObjectOfType<PlantSeeds>();
        plotTracker = GameObject.FindObjectOfType<PlotTracker>();
        plantIcons1 = GameObject.FindObjectOfType<PlantIcons1>();
        sign1Icons = GameObject.FindObjectOfType<Sign1Icons>();
        plot1Plants = GameObject.FindObjectOfType<Plot1Plants>();
        timerText.SetActive(false);
        timerBG.SetActive(false);
        countDown = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (plot1timer > 0)
        {
            collect.SetActive(false);
            collectText.SetActive(false);

            foreach (GameObject f in plot1Plants.plants1)
            {
                f.SetActive(true);
            }

            if (countDown == 0)
            {
                
                plot1timer -= Time.deltaTime;
                timerText.SetActive(true);
                timerBG.SetActive(true);
                timerText.GetComponent<Text>().text = ((Mathf.Round(plot1timer)).ToString());
                //Debug.Log(plot1timer);
            }

            if (plotTracker.plot1Plant == "cabbage")
            {
                sign1Icons.cabbage.SetActive(true);
            }
            else if (plotTracker.plot1Plant == "carrot")
            {
                sign1Icons.carrot.SetActive(true);
            }
            else if (plotTracker.plot1Plant == "corn")
            {
                sign1Icons.corn.SetActive(true);
            }
            else if (plotTracker.plot1Plant == "cucumber")
            {
                sign1Icons.cucumber.SetActive(true);
            }
            else if (plotTracker.plot1Plant == "eggplant")
            {
                sign1Icons.eggplant.SetActive(true);
            }
            else if (plotTracker.plot1Plant == "pumpkin")
            {
                sign1Icons.pumpkin.SetActive(true);
            }
            else if (plotTracker.plot1Plant == "radish")
            {
                sign1Icons.raddish.SetActive(true);
            }
            else
            {
                Debug.LogWarning("Sign icon type not found for plot 1");
            }
        }
        else if (plot1timer < 0)
        {
            plotTracker.plotNumber = 0;
            plot1timer = 0;
            timerText.SetActive(false);
            timerBG.SetActive(false);

            if (plotTracker.plot1Plant == "cabbage")
            {
                plantIcons1.cabbage.SetActive(true);
            }
            else if (plotTracker.plot1Plant == "carrot")
            {
                plantIcons1.carrot.SetActive(true);
            }
            else if (plotTracker.plot1Plant == "corn")
            {
                plantIcons1.corn.SetActive(true);
            }
            else if (plotTracker.plot1Plant == "cucumber")
            {
                plantIcons1.cucumber.SetActive(true);
            }
            else if (plotTracker.plot1Plant == "eggplant")
            {
                plantIcons1.eggplant.SetActive(true);
            }
            else if (plotTracker.plot1Plant == "pumpkin")
            {
                plantIcons1.pumpkin.SetActive(true);
            }
            else if (plotTracker.plot1Plant == "radish")
            {
                plantIcons1.raddish.SetActive(true);
            }
            else
            {
                Debug.LogWarning("Icon type not found for plot 1");
            }
            plantSeeds. seedIndicator.SetActive(false);
            plantSeeds.plantCollector.SetActive(true);
            //Debug.Log(plot1timer);
        }
    }
}

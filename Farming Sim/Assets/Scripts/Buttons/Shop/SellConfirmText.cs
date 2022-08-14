using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellConfirmText : MonoBehaviour
{
    public GameObject soldBG;
    public GameObject SoldText;
    public bool sold;
    Plot1Timer plot1Timer;
    public int soldNum;
    public int money;
    public string plant;

    // Start is called before the first frame update
    void Start()
    {
        soldBG.SetActive(false);
        SoldText.SetActive(false);
        plot1Timer = GameObject.FindObjectOfType<Plot1Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sold)
        {
            SoldText.GetComponent<Text>().text = ("Sold "+soldNum+" "+plant+" for $"+money);
            soldBG.SetActive(true);
            SoldText.SetActive(true);
            plot1Timer.countDown = 1;
            Time.timeScale = 1;
            StartCoroutine(DeleteText());
            sold = false;
        }
    }
    IEnumerator DeleteText()
    {
        yield return new WaitForSeconds(2);
        soldBG.SetActive(false);
        SoldText.SetActive(false);
        Time.timeScale = 0;
        plot1Timer.countDown = 0;
    }
}

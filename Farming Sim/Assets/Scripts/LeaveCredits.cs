using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveCredits : MonoBehaviour
{
    public GameObject credits;

    public void LoadMain()
    {
        Time.timeScale = 0;
        Destroy(credits);
    }

}

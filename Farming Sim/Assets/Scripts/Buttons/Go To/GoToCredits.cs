using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToCredits : MonoBehaviour
{
    public void LoadCredits()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Credits", LoadSceneMode.Additive);
    }
}

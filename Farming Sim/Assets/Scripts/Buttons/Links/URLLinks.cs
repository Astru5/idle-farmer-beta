using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URLLinks : MonoBehaviour
{
    public void OpenInstagram()
    {
        OpenLink.OpenURL("https://www.instagram.com/footnostudios/");
    }
    public void OpenTwitter()
    {
        OpenLink.OpenURL("https://twitter.com/FootnoStudios");
    }
}

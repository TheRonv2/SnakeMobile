using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaleDie : MonoBehaviour
{
    public GameObject Menu;
    public bool men  = false;

    public void PauseGame()
    {
        if (men == false)
        {
            Menu.SetActive(true);
            Time.timeScale = 0;
            men = true;
        }
        else
        {
            Menu.SetActive(false);
            Time.timeScale = 1;
            men = false;
        }
    }
}

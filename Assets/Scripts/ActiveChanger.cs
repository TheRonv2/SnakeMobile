using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveChanger : MonoBehaviour
{
    public GameObject Manager;
    public GameObject Main;
    public GameObject Right;
    public GameObject Left;
    public GameObject Camera;
    public GameObject ClassicManager;
    public GameObject ClassicMain;
    public GameObject ClassicRight;
    public GameObject ClassicLeft;
    public FindAnotherScene anotherScene;

    // Start is called before the first frame update
    public void Update()
    {
        if (anotherScene.j == 1)
        {
            Manager.SetActive(true);
            Main.SetActive(true);
            Right.SetActive(true);
            Left.SetActive(true);
            Camera.SetActive(true);
            ClassicManager.SetActive(false);
            ClassicMain.SetActive(false);
            ClassicRight.SetActive(false);
            ClassicLeft.SetActive(false);
        }
        if (anotherScene.j == 0)
        {
            Manager.SetActive(false);
            Main.SetActive(false);
            Right.SetActive(false);
            Left.SetActive(false);
            Camera.SetActive(false);
            ClassicManager.SetActive(true);
            ClassicMain.SetActive(true);
            ClassicRight.SetActive(true);
            ClassicLeft.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public GameObject AnotherCamera;
    public GameObject Button;
    public GameObject AnotherButton;

    // Update is called once per frame
    public void OnChange()
    {
        gameObject.SetActive(false);
        AnotherCamera.SetActive(true);
        Button.SetActive(false);
        AnotherButton.SetActive(true);
    }
}

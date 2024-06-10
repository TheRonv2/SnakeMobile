using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoadHelper : MonoBehaviour
{
    public Transform start;
    public float distance;
    public Text text;

    public void Update()
    {
        distance = (start.transform.position.z + transform.position.z);
        AllRoad.alldis = distance;
        PlayerPrefs.SetFloat("distance", AllRoad.alldis);
        text.text = distance.ToString("0");
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllRoad : MonoBehaviour
{
    public static float alldis;
    public Text text;
    void Start()
    {
        text.text = alldis.ToString("0");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
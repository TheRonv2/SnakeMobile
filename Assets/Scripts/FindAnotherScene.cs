using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindAnotherScene : MonoBehaviour
{
    public static int i = 0;
    public int j = 0;

    // Start is called before the first frame update
    public void Start()
    {
        i = PlayerPrefs.GetInt("I");
        Debug.Log(i);
    }

    // Update is called once per frame
    public void OnUpdate()
    {
        i = 1;
        PlayerPrefs.SetInt("I", i);
        PlayerPrefs.Save();
    }

    public void OnButton()
    {
        i = 0;
        PlayerPrefs.SetInt("I", i);
        PlayerPrefs.Save();
    }

    public void Update()
    {
        if (i == 1)
        {
            j = 1;
        }
        else
        {
            j = 0;
        }
    }
}

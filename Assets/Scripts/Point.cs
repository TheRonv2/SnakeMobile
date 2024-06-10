using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Respawn"))
        {
            AllPoints.Coin += 1;
            PlayerPrefs.SetInt("coins", AllPoints.Coin);
        }
    }
}

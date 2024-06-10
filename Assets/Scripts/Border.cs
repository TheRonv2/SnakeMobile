using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Border : MonoBehaviour
{
    public string gameName;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SnakeMain")
        {
            SceneManager.LoadScene(gameName);
        }
    }
}

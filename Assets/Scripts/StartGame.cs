using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public string gameName;


    // Start is called before the first frame update
    public void OnStart()
    {
        SceneManager.LoadScene(gameName);
        Time.timeScale = 1;
        AllPoints.Coin = 0;
        AllRoad.alldis = 0;
        PlayerPrefs.SetInt("coins", AllPoints.Coin);
        PlayerPrefs.SetFloat("distance", AllRoad.alldis);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ForIndex : MonoBehaviour
{
    public int indx;
    public SnakeMove snakeMove;

    // Start is called before the first frame update
    public void Start()
    {
        snakeMove = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<SnakeMove>();
        indx = snakeMove.score;
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {
            if (indx > 2)
            {
                SceneManager.LoadScene("FinishScene");
            }
        }
    }
}

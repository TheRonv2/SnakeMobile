using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FollowMenu : MonoBehaviour
{
    public float speed = 5f;
    public Transform player;

    public string gameName;

    public string Name;

    public void Start()
    {
    }


    public void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed);
    }

    public void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.CompareTag(Name))
        {
            SceneManager.LoadScene(gameName);
        }
    }
}

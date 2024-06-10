using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovingPlus : MonoBehaviour
{
    public StartGame start;
    public float speed;
    public Vector3 tailTarget;
    public GameObject tailTargetObj;
    public Moving moving;
    public int indx;
    public GameObject Menu;

    // Start is called before the first frame update
    void Start()
    {
        moving = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<Moving>();
        speed = moving.speed + 2f;
        tailTargetObj = moving.tailObjects[moving.tailObjects.Count-2];
    }

    // Update is called once per frame
    void Update()
    {
        tailTarget = tailTargetObj.transform.position;
        transform.LookAt(tailTarget);
        indx = moving.tailObjects.IndexOf(gameObject);
        transform.position = Vector3.Lerp(transform.position, tailTarget, Time.deltaTime*speed);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {
            if(indx > 2)
            {
                SceneManager.LoadScene("FinishScene");
            }
        }
    }
}

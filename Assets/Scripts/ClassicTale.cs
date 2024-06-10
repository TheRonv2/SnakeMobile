using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClassicTale : MonoBehaviour
{
    public StartGame start;
    public float speed;
    public Vector3 tailTarget;
    public GameObject tailTargetObj;
    public ClassicDie classicDie;
    public int indx;
    public GameObject Menu;

    // Start is called before the first frame update
    void Start()
    {
        classicDie = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<ClassicDie>();
        speed = classicDie.speed + 2f;
        tailTargetObj = classicDie.tailObjects[classicDie.tailObjects.Count - 2];
    }

    // Update is called once per frame
    void Update()
    {
        tailTarget = tailTargetObj.transform.position;
        transform.LookAt(tailTarget);
        indx = classicDie.tailObjects.IndexOf(gameObject);
        transform.position = Vector3.Lerp(transform.position, tailTarget, Time.deltaTime * speed);
    }

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

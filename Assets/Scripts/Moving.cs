using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moving : MonoBehaviour
{
    public float speed;
    public float rotspeed;
    public List<GameObject> tailObjects = new List<GameObject>();
    public float z_offset = 0.5f;
    public GameObject TailPrefab;
    public bool go = false;
    public bool ango = false;
    public Text ScoreText;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        tailObjects.Add(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = score.ToString();
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if ((Input.GetKey(KeyCode.D)) || (go == true))
        {
            transform.Rotate(Vector3.up * rotspeed * Time.deltaTime);
        }
        if ((Input.GetKey(KeyCode.A)) || (ango == true))
        {
            transform.Rotate(Vector3.up * -1 * rotspeed * Time.deltaTime);
        }
    }

    public void OnRight()
    {
        go = true;
    }

    public void NoRight()
    {
        go = false;
    }

    public void OnLeft()
    {
        ango = true;
    }

    public void NoLeft()
    {
        ango = false;
    }

    public void AddTail()
    {
        score++;
        Vector3 newTailPos = tailObjects[tailObjects.Count-1].transform.position;
        newTailPos.z -= z_offset;
        tailObjects.Add(GameObject.Instantiate(TailPrefab, newTailPos, Quaternion.identity) as GameObject);
    }
}

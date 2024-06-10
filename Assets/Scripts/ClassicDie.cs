using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClassicDie : MonoBehaviour
{
    public float speed;
    public List<GameObject> tailObjects = new List<GameObject>();
    public float z_offset = 0.5f;
    public GameObject TailPrefab;
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
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 90, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -90, 0));
        }
    }

    public void OnRight()
    {
        transform.Rotate(new Vector3(0, 90, 0));
    }

    public void OnLeft()
    {
        transform.Rotate(new Vector3(0, -90, 0));
    }

    public void AddTail()
    {
        score++;
        Vector3 newTailPos = tailObjects[tailObjects.Count - 1].transform.position;
        newTailPos.z -= z_offset;
        tailObjects.Add(GameObject.Instantiate(TailPrefab, newTailPos, Quaternion.identity) as GameObject);
    }
}
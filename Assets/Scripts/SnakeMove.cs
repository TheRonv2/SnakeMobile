using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnakeMove : MonoBehaviour
{
    [SerializeField] private List<Transform> _tails;
    [SerializeField] private float _bonesDistance;
    [SerializeField] private GameObject _bonePrefab;
    public float speed;
    public float z_offset = 0.5f;
    public GameObject TailPrefab;
    public List<GameObject> tailObjects = new List<GameObject>();
    public Text ScoreText;
    public int score;

    void Start()
    {
        tailObjects.Add(gameObject);
    }

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

        float sqrDistance = Mathf.Sqrt(_bonesDistance);
        Vector3 previousPosition = transform.position;
        foreach (var bone in _tails)
        {
            if ((bone.position - previousPosition).sqrMagnitude > sqrDistance)
            {
                Vector3 currentBonePosition = bone.position;
                bone.position = previousPosition;
                previousPosition = currentBonePosition;
            }
            else
            {
                break;
            }
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

    void OnTriggerEnter (Collider other)
    {
        if (other.TryGetComponent(out FoodNo eat))
        {
            Destroy(other.gameObject);
            GameObject bone = Instantiate(_bonePrefab);
            _tails.Add(bone.transform);
            score++;
        }
    }
}

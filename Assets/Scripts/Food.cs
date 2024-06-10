using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public float XSize = 8f;
    public float ZSize = 8f;
    public GameObject FoodPrefab;
    public Vector3 curPos;
    public GameObject curFood;

    public void AddNewFood()
    {
        RandomPos();
        curFood = GameObject.Instantiate(FoodPrefab, curPos, Quaternion.identity) as GameObject;
    }

    public void RandomPos()
    {
        curPos = new Vector3(Random.Range((XSize * -1)-30f, XSize-30f), 0.7f, Random.Range(ZSize * -1, ZSize));
    }

    public void Update()
    {
        if (!curFood)
        {
            AddNewFood();
        }
        else
        {
            return;
        }
    }
}

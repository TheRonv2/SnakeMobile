using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodEat : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Moving>().AddTail();
        Destroy(gameObject);
    }
}

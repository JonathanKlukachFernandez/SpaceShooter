using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagedByCollision : MonoBehaviour
{
    void OnCollisionEnter2D()
    {
        Debug.Log("Collision!");
    }

    void OnTriggerEnter2D()
    {
        Debug.Log("Trigger!");
    }
}

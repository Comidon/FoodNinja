using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity.Interaction;

public class Food : MonoBehaviour
{
    public Assets.Scripts.Utilities.FoodType type;
    public Nutrition nutrition { get; protected set; }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Floor"))
        {
            Destroy(gameObject);
        }
    }
}

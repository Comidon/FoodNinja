using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Utilities;

public class SpawnerRing : MonoBehaviour
{
    [SerializeField]
    private float startDelay = 2;
    [SerializeField]
    private float gapDuration = 0.5f;
    [SerializeField]
    private float maxSpawnDelay = 2;
    [SerializeField]
    private float force = 5;
    [SerializeField]
    private float forceHeight = 0.5f;
    [SerializeField]
    private float radius = 8;

    private Vector3 pos;
    private System.Random random;

    private void Awake()
    {
        pos = transform.position;
        random = new System.Random();
    }

    private void Start()
    {
        InvokeRepeating("_RandomlySpawnSomethingSomewhere", startDelay, gapDuration);
    }

    private IEnumerator _DelaySpawn()
    {
        yield return new WaitForSeconds(maxSpawnDelay);
        _RandomlySpawnSomethingSomewhere();
    }

    private void _RandomlySpawnSomethingSomewhere()
    {
        var typeValues = FoodType.GetValues(typeof(FoodType));
        FoodType randomType = (FoodType) typeValues.GetValue(random.Next(typeValues.Length));
        double angle = random.NextDouble() * Math.PI * 2;

        Vector3 vecDiff = new Vector3(radius * (float)Math.Sin(angle), 0, radius * (float)Math.Cos(angle));

        int goForChicken = random.Next();

        GameObject food;

        if (goForChicken % 7 == 1)
        {
            food = FoodFactory.instance.GiveFood(FoodType.FriedChicken, pos + vecDiff);
        }
        else
        {
            food = FoodFactory.instance.GiveFood(randomType, pos + vecDiff);
        }

        Vector3 vecForce = (-vecDiff.normalized + new Vector3(0, forceHeight, 0)) * force;

        food.GetComponent<Rigidbody>().AddForce(vecForce, ForceMode.VelocityChange);
    }
}

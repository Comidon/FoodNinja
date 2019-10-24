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
    private float force;

    private System.Random random;

    private void Awake()
    {
        random = new System.Random();
    }

    private void Start()
    {
        InvokeRepeating("_RandomlySpawnSomething", startDelay, gapDuration);
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
        
    }
}

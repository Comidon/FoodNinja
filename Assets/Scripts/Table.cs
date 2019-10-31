﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour, FoodToAchievement_Interface
{
    private HashSet<Food> foodSet;
    public AudioSource tableAudioSource;
    private void Awake()
    {
        foodSet = new HashSet<Food>();
        DontDestroyOnLoad(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Food foodScript = other.GetComponentInParent<Food>();
        if (foodScript != null)
        {
            foodSet.Add(foodScript);
            if (NutritionManager.instance != null)
                NutritionManager.instance.addUpNutritionAmount(foodScript.nutrition);
                tableAudioSource.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Food foodScript = other.GetComponentInParent<Food>();
        if (foodScript != null)
        {
            foodSet.Remove(foodScript);
            if (NutritionManager.instance != null)
                NutritionManager.instance.subUpNutritionAmount(foodScript.nutrition);
        }
    }

    public HashSet<Food> GetFoodOnTable()
    {
        foreach (Food food in foodSet)
        {
            DontDestroyOnLoad(food.gameObject);
        }
        return foodSet;
    }
}

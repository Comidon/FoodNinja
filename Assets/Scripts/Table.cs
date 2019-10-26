using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour, FoodToAchievement_Interface
{
    private HashSet<Food> foodSet;

    private void Awake()
    {
        foodSet = new HashSet<Food>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Food foodScript = other.GetComponentInParent<Food>();
        if (foodScript != null)
        {
            foodSet.Add(foodScript);
            NutritionManager.instance.addUpNutritionAmount(foodScript.nutrition);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Food foodScript = other.GetComponentInParent<Food>();
        if (foodScript != null)
        {
            foodSet.Remove(foodScript);
            NutritionManager.instance.subUpNutritionAmount(foodScript.nutrition);
        }
    }

    public HashSet<Food> GetFoodOnTable()
    {
        return foodSet;
    }
}

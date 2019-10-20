using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts.Utilities;

public class NutritionManager : MonoBehaviour
{
    private Dictionary<NutritionType, Slider> bars;

    // Singleton instance
    public static NutritionManager instance;

    private void Awake()
    {
        // Singleton check
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }

        bars = new Dictionary<NutritionType, Slider>();
        Slider[] sliders = GetComponentsInChildren<Slider>();
        foreach (Slider slider in sliders)
        {
            string name = slider.gameObject.name;
            NutritionType result;
            if(Enum.TryParse(name, out result))
            {
                bars.Add(result, slider);
            }
        }
    }

    public void initializeNutritionTotal(Nutrition nutrition)
    {
        foreach(KeyValuePair<NutritionType,float> entry in nutrition.getNutritionDict())
        {
            bars[entry.Key].GetComponent<BarController>().initialMaximum(entry.Value);
        }
    }

    public void addUpNutritionAmount(Nutrition nutrition)
    {
        foreach (KeyValuePair<NutritionType, float> entry in nutrition.getNutritionDict())
        {
            bars[entry.Key].GetComponent<BarController>().changeCurrentTotal(entry.Value);
        }
    }

    public void subUpNutritionAmount(Nutrition nutrition)
    {
        foreach (KeyValuePair<NutritionType, float> entry in nutrition.getNutritionDict())
        {
            bars[entry.Key].GetComponent<BarController>().changeCurrentTotal(-entry.Value);
        }
    }
}

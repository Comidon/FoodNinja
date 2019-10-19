using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts.Utilities;

public class NutritionManager:MonoBehaviour
{
    private Dictionary<NutritionType, Slider> bars;

    private void Start()
    {
        //Slider[] sliders = GetComponents<Slider>();
        Slider[] sliders = GetComponentsInChildren<Slider>();
        foreach(Slider slider in sliders)
        {
            string name = slider.name;
            NutritionType result;
            if(Enum.TryParse(name, out result))
            {
                bars[result] = slider;
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
}

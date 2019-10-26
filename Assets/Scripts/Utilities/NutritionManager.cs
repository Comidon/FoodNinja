using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts.Utilities;

public class NutritionManager : MonoBehaviour,ManagerToAchievement
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

        // TEMP:
        initializeNutritionTotal(new Nutrition(2000, 100, 50, 2400, 50));
        //initializeNutritionTotal(new Nutrition(getNutrition.kcal, getNutrition.sugar, getNutrition.fat, getNutrition.salt, getNutrition.protein));
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

    public Nutrition getCollectedTotal()
    {
        Nutrition collected = new Nutrition();
        collected.Calories = bars[NutritionType.Calories].GetComponent<BarController>().CurrentTotal;
        collected.Protein = bars[NutritionType.Protein].GetComponent<BarController>().CurrentTotal;
        collected.Salt = bars[NutritionType.Salt].GetComponent<BarController>().CurrentTotal;
        collected.Sugar = bars[NutritionType.Sugar].GetComponent<BarController>().CurrentTotal;
        collected.Fat = bars[NutritionType.Fat].GetComponent<BarController>().CurrentTotal;

        return collected;
    }

    public Nutrition getExpectedTotal()
    {
        Nutrition collected = new Nutrition();
        collected.Calories = bars[NutritionType.Calories].GetComponent<BarController>().Maximum;
        collected.Protein = bars[NutritionType.Protein].GetComponent<BarController>().Maximum;
        collected.Salt = bars[NutritionType.Salt].GetComponent<BarController>().Maximum;
        collected.Sugar = bars[NutritionType.Sugar].GetComponent<BarController>().Maximum;
        collected.Fat = bars[NutritionType.Fat].GetComponent<BarController>().Maximum;

        return collected;
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Utilities;

public class FatSetter : AchievementValueSetter
{
    public override Food getMax()
    {
        Food result = null;
        float max = 0;
        foreach (Food food in DataToAchievement.food)
        {
            if (food.nutrition.Fat >= max)
            {
                result = food;
                max = food.nutrition.Fat;
            }
        }

        return result;
    }

    // Start is called before the first frame update
    void Start()
    {
        float total = DataToAchievement.Expected.Fat;
        float max = DataToAchievement.Max.Fat;

        Food food = getMax();
        pri_type = food.type.ToString();
        loadMesh(pri_type);
        pri_amount = (food.nutrition.Fat / max * 100).ToString("R");
        pri_nutrition = NutritionType.Fat.ToString();

        setBar(total, max);
        setTotal(total);
        setMaximum(max);
        setWholeString();
        setPie(food.nutrition.Fat / max);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Utilities;
public class CaloriesSetter : AchievementValueSetter
{
    public override Food getMax()
    {
        Food result=null;
        float max = 0;
        foreach(Food food in DataToAchievement.food)
        {
            if (food.nutrition.Calories >= max)
            {
                result = food;
                max = food.nutrition.Calories;
            }
        }

        return result;
    }

    // Start is called before the first frame update
    void Start()
    {
        float total = DataToAchievement.Expected.Calories;
        float max = DataToAchievement.Max.Calories;

        Food food = getMax();
        pri_type = food.type.ToString();
        loadMesh(pri_type);
        pri_amount = (food.nutrition.Calories / max * 100).ToString("R");
        pri_nutrition = NutritionType.Calories.ToString();

        setBar(total, max);
        setTotal(total);
        setMaximum(max);
        setWholeString();
        setPie(food.nutrition.Calories / max);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

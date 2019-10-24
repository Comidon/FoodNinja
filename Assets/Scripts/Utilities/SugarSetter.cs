using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Utilities;

public class SugarSetter : AchievementValueSetter
{
    public override Food getMax()
    {
        Food result = null;
        float max = 0;
        foreach (Food food in FoodToAchievement.GetFoodOnTable())
        {
            if (food.nutrition.Sugar > max)
            {
                result = food;
                max = food.nutrition.Sugar;
            }
        }

        return result;
    }

    // Start is called before the first frame update
    void Start()
    {
        float total = DataToAchievement.Expected_Default.Sugar;
        float max = DataToAchievement.Max_Default.Sugar;

        //Food food = getMax();
        //Food food = ;
        loadMesh("Apple");

        pri_nutrition = NutritionType.Sugar.ToString();
        pri_type = "Apple";
        pri_amount = "30.5";

        setBar(total, max);
        setTotal(total);
        setMaximum(max);
        setFoodType();
        setWholeString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

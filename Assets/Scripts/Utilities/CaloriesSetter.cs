using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaloriesSetter : AchievementValueSetter
{
    public override Food getMax()
    {
        Food result=null;
        float max = 0;
        foreach(Food food in FoodToAchievement.GetFoodOnTable())
        {
            if (food.nutrition.Calories > max)
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
        float total = DataToAchievement.Expected_Default.Calories;
        float max = DataToAchievement.Max_Default.Calories;

        setBar(total, max);
        setTotal(total);
        setMaximum(max);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

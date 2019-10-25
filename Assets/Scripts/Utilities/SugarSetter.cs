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

        Food food = getMax();
        pri_type = food.type.ToString();
        pri_amount = (food.nutrition.Sugar/max*100).ToString("R");
        pri_nutrition = NutritionType.Sugar.ToString();

        loadMesh(pri_type);

        setBar(total, max);
        setTotal(total);
        setMaximum(max);
        setWholeString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

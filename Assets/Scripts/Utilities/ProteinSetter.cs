using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProteinSetter : AchievementValueSetter
{
    public override Food getMax()
    {
        Food result = null;
        float max = 0;
        foreach (Food food in FoodToAchievement.GetFoodOnTable())
        {
            if (food.nutrition.Protein > max)
            {
                result = food;
                max = food.nutrition.Protein;
            }
        }

        return result;
    }

    // Start is called before the first frame update
    void Start()
    {
        float total = DataToAchievement.Expected_Default.Protein;
        float max = DataToAchievement.Max_Default.Protein;

        setBar(total, max);
        setTotal(total);
        setMaximum(max);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

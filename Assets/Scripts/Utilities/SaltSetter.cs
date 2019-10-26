using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Utilities;

public class SaltSetter : AchievementValueSetter
{
    public override Food getMax()
    {
        Food result = null;
        float max = 0;
        foreach (Food food in DataToAchievement.food)
        {
            if (food.nutrition.Salt > max)
            {
                result = food;
                max = food.nutrition.Salt;
            }
        }

        return result;
    }

    // Start is called before the first frame update
    void Start()
    {
        float total = DataToAchievement.Expected.Salt;
        float max = DataToAchievement.Max.Salt;

        Food food = getMax();
        pri_type = food.type.ToString();
        loadMesh(pri_type);
        pri_amount = (food.nutrition.Salt / max * 100).ToString("R");
        pri_nutrition = NutritionType.Salt.ToString();

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

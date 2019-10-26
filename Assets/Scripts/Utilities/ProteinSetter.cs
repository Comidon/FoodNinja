using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Utilities;

public class ProteinSetter : AchievementValueSetter
{
    public override Food getMax()
    {
        Food result = null;
        float max = 0;
        foreach (Food food in DataToAchievement.food)
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
        float total = DataToAchievement.Expected.Protein;
        float max = DataToAchievement.Max.Protein;

        Food food = getMax();
        pri_type = food.type.ToString();
        loadMesh(pri_type);
        pri_amount = (food.nutrition.Protein / max * 100).ToString("R");
        pri_nutrition = NutritionType.Protein.ToString();

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaloriesSetter : AchievementValueSetter
{
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

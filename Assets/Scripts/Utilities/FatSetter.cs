using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatSetter : AchievementValueSetter
{
    // Start is called before the first frame update
    void Start()
    {
        float total = DataToAchievement.Expected_Default.Fat;
        float max = DataToAchievement.Max_Default.Fat;

        setBar(total, max);
        setTotal(total);
        setMaximum(max);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

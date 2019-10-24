using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProteinSetter : AchievementValueSetter
{
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

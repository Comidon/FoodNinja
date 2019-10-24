using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class AchievementValueSetter:MonoBehaviour
{
    public Slider Nutrition_Slider;
    public Text Total_Amount_Text;
    public Text Expected_Amount_Text;

    protected void setBar(float total,float max)
    {
        Nutrition_Slider.value = total / max > 1 ? 100 : total / max * 100;
    }

    protected void setTotal(float nutrition)
    {
        Total_Amount_Text.text = nutrition.ToString("R");
    }

    protected void setMaximum(float nutrition)
    {
        Expected_Amount_Text.text = nutrition.ToString("R");
    }
}

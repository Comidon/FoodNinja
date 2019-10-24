using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts.Utilities;

public abstract class AchievementValueSetter:MonoBehaviour
{
    public GameObject panel;
    public Slider Nutrition_Slider;
    public Text Total_Amount_Text;
    public Text Expected_Amount_Text;
    public Text Food_Type;
    public Text Content;
    public FoodToAchievement_Interface FoodToAchievement;

    protected string pri_type;
    protected string pri_amount;
    protected string pri_nutrition;

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

    protected void loadMesh(string food_type)
    {
        //for testing
        string foodtype = "Apple";

        GameObject gameObject= Instantiate(Resources.Load(foodtype) as GameObject, new Vector3(-600, 0, 0), Quaternion.identity);
        gameObject.transform.parent = panel.transform;
    }

    protected void setWholeString()
    {
        Content.text= "Do you know that " + pri_type + " contains\n" + pri_amount + "% of your daily " + pri_nutrition + " value?";
    }

    protected void setFoodType()
    {
        Food_Type.text = pri_type;
    }

    public abstract Food getMax();
}

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
    public Text Content;
    public FoodToAchievement_Interface FoodToAchievement;
    public Image Whole;
    public Image Part;

    protected string pri_type;
    protected string pri_amount;
    protected string pri_nutrition;

    protected void setBar(float total,float max)
    {
        float value = total / max * 100;
        Nutrition_Slider.value = total / max > 1 ? 100 : total / max * 100;
        Image fill_area = null;
        foreach(Image image in Nutrition_Slider.GetComponentsInChildren<Image>())
        {
            if (image.name == "Fill")
            {
                fill_area = image;
            }
        }

        if (value < 90)
        {
            fill_area.color = Color.yellow;
        }else if (value >= 90 && value <= 110)
        {
            fill_area.color = Color.green;
        }
        else
        {
            fill_area.color = Color.red;
        }
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
        //string foodtype = "Apple";
        print("food type:" + food_type);
        GameObject gameObject= Instantiate(Resources.Load(food_type) as GameObject);
        gameObject.transform.parent = panel.transform;
        gameObject.transform.localPosition = new Vector3(-600, 0, 0);
        gameObject.transform.localScale = new Vector3(7000f, 7000f, 7000f);
        gameObject.GetComponent<Rigidbody>().useGravity = false;
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
        //gameObject.GetComponent<Collider>().enabled = false;
    }

    protected void setWholeString()
    {
        /**
        pri_type = "Apple";
        pri_amount = "35";
        pri_nutrition = "Sugar";
    */
        //print("Do you know that the amount of " + pri_nutrition + "\n ONE " + pri_type + " contains makes up of\n" + pri_amount + "% of your daily value?");
        Content.text= "Do you know that the amount of " + pri_nutrition + "\n ONE " + pri_type + " contains makes up of\n" + pri_amount + "% of your daily value?";
    }

    protected void setPie(float percent)
    {
        Part.fillAmount = percent;
        Whole.fillAmount = 1 - Part.fillAmount;
        Whole.transform.localRotation = Quaternion.Euler(new Vector3(0 , 0, -360 * Part.fillAmount));
    }

    public abstract Food getMax();
}

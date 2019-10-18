using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Utilities;

public class Nutrition
{
    private Dictionary<NutritionType, float> nutritionDict=new Dictionary<NutritionType, float>();

    public Nutrition()
    {
        foreach(NutritionType type in Enum.GetValues(typeof(NutritionType)){
            nutritionDict[type] = 0;
        }
    }

    public Nutrition(float sugar, float fat, float salt, float protein)
    {
        nutritionDict[NutritionType.Sugar] = sugar;
        nutritionDict[NutritionType.Fat] = fat;
        nutritionDict[NutritionType.Salt] = salt;
        nutritionDict[NutritionType.Protein] = protein;
    }

    public Nutrition(Nutrition nutrition)
    { 
        nutritionDict[NutritionType.Sugar] = nutrition.Sugar;
        nutritionDict[NutritionType.Fat] = nutrition.Fat;
        nutritionDict[NutritionType.Salt] = nutrition.Salt;
        nutritionDict[NutritionType.Protein] = nutrition.Protein;
    }

    public float Sugar
    {
        get { return nutritionDict[NutritionType.Sugar]; }
        set { nutritionDict[NutritionType.Sugar] = value; }
    }

    public float Fat
    {
        get { return nutritionDict[NutritionType.Fat]; }
        set { nutritionDict[NutritionType.Fat] = value; }
    }

    public float Salt
    {
        get { return nutritionDict[NutritionType.Salt]; }
        set { nutritionDict[NutritionType.Salt] = value; }
    }

    public float Protein
    {
        get { return nutritionDict[NutritionType.Protein]; }
        set { nutritionDict[NutritionType.Protein] = value; }
    }

    public Dictionary<NutritionType,float> getNutritionDict()
    {
        return nutritionDict;
    }
}

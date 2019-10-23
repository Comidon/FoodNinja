using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class getNutrition : MonoBehaviour
{
    private string gender;
    private double weight;
    private double height;
    private decimal age;
    private float kcal;
    private float sugar;
    private float salt;
    private float protein;
    private float fat;
    // Start is called before the first frame update
    void Start()
    {
        
        //gender = String.Copy(GenderSelection.Gender2);
        //gender = genderValue.getGender();
        //WeightSelection weightValue = new WeightSelection();
        //weight = weightValue.getWeight();
        //HeightSelection heightValue = new HeightSelection();
        //height = heightValue.getHeight();
        //AgeSelection ageValue = new AgeSelection();
        //age = ageValue.getAge();
        /*string s1 = "Male";
        string s2 = "Female";
        if(String.Compare(gender,s1)==0)
        {
            kcal = 10 * weight + 6.25 * height - 5 * (int)age + 5;
        }
        else if (String.Compare(gender, s2) == 0)
        {
            kcal = 10 * weight + 6.25 * height - 5 * (int)age -161;
        }*/
    }
    public void fromGender()
    {
        gender = String.Copy(GenderSelection.Gender2);
    }
    public void fromWeight()
    {
        weight = WeightSelection.weightValue;
    }
    public void fromHeight()
    {
        height = HeightSelection.heightValue;
    }
    public void fromAge()
    {
        age = AgeSelection.ageValue;
    }
    public void getKcal()
    {
        string s1 = "Male";
        string s2 = "Female";
        if (String.Compare(gender, s1) == 0)
        {
            kcal = (float)(10 * weight + 6.25 * height - 5 * (int)age + 5);
        }
        else if (String.Compare(gender, s2) == 0)
        {
            kcal = (float)(10 * weight + 6.25 * height - 5 * (int)age - 161);
        }
    }
    public void getSugar()
    {
        sugar = (float)(0.6 * kcal/4);
    }
    public void getSalt()
    {
        salt =(float)2.3;
    }
    public void getProtein()
    {
        protein = (float)(0.1 * kcal / 4);
    }
    public void getFat()
    {
        fat = (kcal/4) - sugar - salt - protein;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("return gender:" + gender);
        Debug.Log("return weight:" + weight);
        Debug.Log("return kcal:" + kcal);
        Debug.Log("return sugar:" + sugar);
        Debug.Log("return salt:" + salt);
        Debug.Log("return protein:" + protein);
        Debug.Log("return fat:" + fat);
    }
}

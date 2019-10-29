using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Utilities;

public class NutritionListSetter : MonoBehaviour
{
    public TextMesh text;

    // Start is called before the first frame update
    void Start()
    {
        HashSet<Food> foods = DataToAchievement.food;
        Dictionary<FoodType, Nutrition> ListNoRepeat = new Dictionary<FoodType, Nutrition>();
        foreach(Food type in foods)
        {
            if (!ListNoRepeat.ContainsKey(type.type))
            {
                ListNoRepeat[type.type] = type.nutrition;
            }
        }

        string wholeList = "";
        wholeList += "Nutrition List\n";
        wholeList += "Name             Calories  Fat       Sugar     Salt      Protein\n";

        foreach(KeyValuePair<FoodType,Nutrition> entry in ListNoRepeat)
        {
            wholeList += entry.Key.ToString();
            int spaceNum = 17 - wholeList.Length;
            wholeList = addSpace(wholeList, spaceNum);
            
            string temp = (entry.Value.Calories).ToString();
            wholeList += temp;
            spaceNum = 10 - temp.Length;
            wholeList = addSpace(wholeList, spaceNum);

            temp = (entry.Value.Fat).ToString();
            wholeList += temp;
            spaceNum = 10 - temp.Length;
            wholeList = addSpace(wholeList, spaceNum);

            temp = (entry.Value.Sugar).ToString();
            wholeList += temp;
            spaceNum = 10 - temp.Length;
            wholeList = addSpace(wholeList, spaceNum);

            temp = (entry.Value.Salt).ToString();
            wholeList += temp;
            spaceNum = 10 - temp.Length;
            wholeList = addSpace(wholeList, spaceNum);

            temp = (entry.Value.Protein).ToString();
            wholeList += temp;
            spaceNum = 10 - temp.Length;
            wholeList = addSpace(wholeList, spaceNum);
        }
    }

    private string addSpace(string input,int num)
    {
        string newInput = input;
        for(var i = 0; i < num; i++)
        {
            newInput += " ";
        }
        return newInput;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

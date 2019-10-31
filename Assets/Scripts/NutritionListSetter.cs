using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Utilities;

public class NutritionListSetter : MonoBehaviour
{
    public TextMesh text;
    public GameObject ParentObject;

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
        float y_start = 0.25f;//decrease 0.05

        foreach(KeyValuePair<FoodType,Nutrition> entry in ListNoRepeat)
        {
            y_start -= 0.05f;

            wholeList = entry.Key.ToString();
            addNewText(wholeList, new Vector3(-1, y_start, 0));
            
            wholeList = (entry.Value.Calories).ToString();
            addNewText(wholeList, new Vector3(-0.5f, y_start, 0));

            wholeList = (entry.Value.Fat).ToString();
            addNewText(wholeList, new Vector3(-0.3f, y_start, 0));

            wholeList = (entry.Value.Sugar).ToString();
            addNewText(wholeList, new Vector3(-0.1f, y_start, 0));

            wholeList = (entry.Value.Salt).ToString();
            addNewText(wholeList, new Vector3(0.1f, y_start, 0));

            wholeList = (entry.Value.Protein).ToString();
            addNewText(wholeList, new Vector3(0.3f,y_start, 0));
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

    private void addNewText(string text,Vector3 position)
    {
        GameObject newText = new GameObject(text);
        newText.transform.parent = ParentObject.transform;
        newText.transform.localPosition = position;
        newText.AddComponent<MeshRenderer>();
        TextMesh textMesh=newText.AddComponent<TextMesh>();
        textMesh.font = Resources.Load("Starker Marker.ttf", typeof(Font)) as Font;
        textMesh.fontSize = 20;
        textMesh.text = text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

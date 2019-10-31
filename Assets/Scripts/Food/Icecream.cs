using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icecream : Food
{
    [Header("Food Properties")]
    [SerializeField]
    private float calories = 130;
    [SerializeField]
    private float sugar = 34;
    [SerializeField]
    private float fat = 0;
    [SerializeField]
    private float salt = 0;
    [SerializeField]
    private float protein = 1;

    private void Awake()
    {
        MeshRenderer[] meshs = GetComponentsInChildren<MeshRenderer>();

        materials = new List<Material>();

        type = Assets.Scripts.Utilities.FoodType.Icecream;

        foreach (MeshRenderer item in meshs)
        {
            materials.Add(item.material);
        }

        nutrition = new Nutrition(calories, sugar, fat, salt, protein);
        iB = GetComponent<Leap.Unity.Interaction.InteractionBehaviour>();
    }
}

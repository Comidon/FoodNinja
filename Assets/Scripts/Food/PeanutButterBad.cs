using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeanutButterBad : Food
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

        foreach (MeshRenderer item in meshs)
        {
            materials.Add(item.material);
        }

        nutrition = new Nutrition(calories, sugar, fat, salt, protein);
    }
}

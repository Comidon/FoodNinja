using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : Food
{
    [Header("Food Properties")]
    [SerializeField]
    private float appleCalories = 130;
    [SerializeField]
    private float appleSugar = 34;
    [SerializeField]
    private float appleFat = 0;
    [SerializeField]
    private float appleSalt = 0;
    [SerializeField]
    private float appleProtein = 1;

    private void Awake()
    {
        MeshRenderer[] meshs = GetComponentsInChildren<MeshRenderer>();

        materials = new List<Material>();

        type = Assets.Scripts.Utilities.FoodType.Apple;

        foreach (MeshRenderer item in meshs)
        {
            materials.Add(item.material);
        }

        nutrition = new Nutrition(appleCalories, appleSugar, appleFat, appleSalt, appleProtein);
        iB = GetComponent<Leap.Unity.Interaction.InteractionBehaviour>();
    }
}

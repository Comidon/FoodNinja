using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : Food
{
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
        nutrition = new Nutrition(appleCalories, appleSugar, appleFat, appleSalt, appleProtein);
    }
}

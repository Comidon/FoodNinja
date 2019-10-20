using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyBar : Food
{
    [Header("Food Properties")]
    [SerializeField]
    private float candyBarCalories = 210;
    [SerializeField]
    private float candyBarSugar = 27;
    [SerializeField]
    private float candyBarFat = 11;
    [SerializeField]
    private float candyBarSalt = 30;
    [SerializeField]
    private float candyBarProtein = 3;

    private void Awake()
    {
        nutrition = new Nutrition(candyBarCalories, candyBarSugar, candyBarFat, candyBarSalt, candyBarProtein);
    }
}

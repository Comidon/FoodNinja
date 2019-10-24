using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NutritionBarTest : MonoBehaviour
{
    private NutritionManager nutritionManager;
    // Start is called before the first frame update
    void Start()
    {
        print("Test Start");
        nutritionManager = GetComponentInChildren<NutritionManager>();
        Nutrition nutrition = new Nutrition(100, 100, 100, 100, 100);
        nutritionManager.initializeNutritionTotal(nutrition);
    }

    // Update is called once per frame
    void Update()
    {
        Nutrition nutrition = new Nutrition((float)0.01, (float)0.01, (float)0.01, (float)0.01, (float)0.01);
        nutritionManager.addUpNutritionAmount(nutrition);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Leap.Unity;

public class GoodToGo : MonoBehaviour
{
    [SerializeField]
    private Table table;

    private bool _counting = false;

    public void Change()
    {
        _counting = true;
        StartCoroutine(_Count());
    }

    public void RevertChange()
    {
        _counting = false;
    }

    private IEnumerator _Count()
    {
        yield return new WaitForSeconds(2f);

        if (_counting)
        {
            DataToAchievement.Expected = NutritionManager.instance.getExpectedTotal();
            DataToAchievement.Max = NutritionManager.instance.getCollectedTotal();
            DataToAchievement.food = table.GetFoodOnTable();
            SceneManager.LoadScene("Dynamic UI");
        }
    }
}

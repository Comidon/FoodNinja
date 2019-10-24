using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Utilities;

public class FoodFactory : MonoBehaviour
{
    [Header("Food Prefabs")]
    [SerializeField]
    private GameObject apple;
    [SerializeField]
    private GameObject candyBar;

    private Dictionary<FoodType, GameObject> foodReference;

    public static FoodFactory instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }

        foodReference = new Dictionary<FoodType, GameObject>();
        foodReference[FoodType.Apple] = apple;
        foodReference[FoodType.CandyBar] = candyBar;
    }

    public GameObject GiveFood(FoodType type, Vector3 pos)
    {
        return Instantiate(foodReference[type], pos, Quaternion.identity);
    }

    public GameObject GiveApple()
    {
        return Instantiate(apple);
    }

    public GameObject GiveApple(Vector3 position)
    {
        return Instantiate(apple, position, transform.rotation);
    }

    public GameObject GiveCandybar()
    {
        return Instantiate(candyBar);
    }

    public GameObject GiveCandybar(Vector3 position)
    {
        return Instantiate(candyBar, position, transform.rotation);
    }

}

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
    [SerializeField]
    private GameObject cereal;
    [SerializeField]
    private GameObject chips;
    [SerializeField]
    private GameObject cola;
    [SerializeField]
    private GameObject fish;
    [SerializeField]
    private GameObject friedChicken;
    [SerializeField]
    private GameObject icecream;
    [SerializeField]
    private GameObject peanutButterBad;
    [SerializeField]
    private GameObject peanutButterGood;
    [SerializeField]
    private GameObject peanuts;
    [SerializeField]
    private GameObject pizza;
    [SerializeField]
    private GameObject riceB;
    [SerializeField]
    private GameObject riceW;

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
        foodReference[FoodType.Cereal] = cereal;
        foodReference[FoodType.Chips] = chips;
        foodReference[FoodType.Cola] = cola;
        foodReference[FoodType.Fish] = fish;
        foodReference[FoodType.FriedChicken] = friedChicken;
        foodReference[FoodType.Icecream] = icecream;
        foodReference[FoodType.PeanutButterBad] = peanutButterBad;
        foodReference[FoodType.PeanutButterGood] = peanutButterGood;
        foodReference[FoodType.Peanuts] = peanuts;
        foodReference[FoodType.Pizza] = pizza;
        foodReference[FoodType.RiceB] = riceB;
        foodReference[FoodType.RiceW] = riceW;
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

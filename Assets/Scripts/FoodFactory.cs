using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodFactory : MonoBehaviour
{
    [Header("Food Prefabs")]
    [SerializeField]
    private GameObject apple;
    [SerializeField]
    private GameObject candyBar;

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

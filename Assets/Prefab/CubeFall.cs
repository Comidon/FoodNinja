using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFall : MonoBehaviour
{
    public float delaySpawn = 1f;
    public float delayBreak = 0.3f;
    public GameObject cube1;
    public GameObject cylinder1;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawning", delaySpawn, delayBreak);
    }

    void Spawning()
    {
        FoodFactory.instance.GiveApple(new Vector3(Random.Range(-3, 3), 20, Random.Range(-10, 10)));
        FoodFactory.instance.GiveCandybar(new Vector3(Random.Range(-3, 3), 20, Random.Range(-10, 10)));
    }
    // Update is called once per frame
    void Update()
    {

    }
}

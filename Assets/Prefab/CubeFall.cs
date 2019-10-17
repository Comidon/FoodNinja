using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFall : MonoBehaviour
{
    public float delay = 0.3f;
    public GameObject cube1;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawning", delay, delay);
    }

    void Spawning()
    {
        Instantiate(cube1, new Vector3(Random.Range(-6, 6), Random.Range(-10, 10), 10), Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {

    }
}

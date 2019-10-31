using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMNotDestroy : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}

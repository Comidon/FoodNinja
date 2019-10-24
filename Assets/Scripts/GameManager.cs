using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Vector3 gravityScale;

    private void Awake()
    {
        Physics.gravity = gravityScale;
    }
}

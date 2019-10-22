using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity.Interaction;

public class Food : MonoBehaviour
{
    public Assets.Scripts.Utilities.FoodType type { get; protected set; }
    public Nutrition nutrition { get; protected set; }

    [SerializeField]
    private int fadeOutDuration = 100;

    protected Color color;
    protected Material material;

    private bool dead = false;

    private void _FadeOut()
    {
        StartCoroutine(_DoFade());
    }

    private IEnumerator _DoFade()
    {
        int i = fadeOutDuration;

        while (i > 0)
        {
            color.a = (float) i / fadeOutDuration;
            material.color = color;
            i--;

            yield return 0;
        }

        Destroy(gameObject);
    }

    void OnCollisionEnter(Collision col)
    {
        if (!dead)
        {
            if (col.gameObject.CompareTag("Floor"))
            {
                dead = true;
                _FadeOut();
            }
        }
    }
}

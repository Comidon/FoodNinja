using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity.Interaction;

public class Food : MonoBehaviour
{
    public Assets.Scripts.Utilities.FoodType type { get; protected set; }
    public Nutrition nutrition { get; protected set; }
    public int points { get; protected set; }

    [SerializeField]
    private int fadeOutDuration = 100;

    protected List<Material> materials;

    private bool dead = false;

    public void CollectPoints()
    {
        // TODO: Collect Points
        // ScoreManager.instance.AddPoints(points);
        Destroy(gameObject);
    }

    private void _FadeOut()
    {
        StartCoroutine(_DoFade());
    }

    private IEnumerator _DoFade()
    {
        int i = fadeOutDuration;

        while (i > 0)
        {
            for (int j = 0; j < materials.Count; j++)
            {
                Color tempC = materials[j].color;
                tempC.a = (float)i / fadeOutDuration;
                materials[j].color = tempC;
            }
            
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity.Interaction;

public class Food : MonoBehaviour
{
    public Assets.Scripts.Utilities.FoodType type { get; protected set; }
    public Nutrition nutrition { get; protected set; }
    public int points { get; protected set; }

    protected int fadeOutDuration = 100;

    protected InteractionBehaviour iB;

    protected List<Material> materials;

    private bool dead = false;

    private bool inHand = false;

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

            /*if (iB.isGrasped)
            {
                NutritionManager.instance.addTempNutritionAmount(nutrition);
            }
            else
            {
                NutritionManager.instance.subTempNutritionAmount(nutrition);
            }*/
        }
    }

    private void Update()
    {
        if (iB.isGrasped)
        {
            if (!inHand)
            {
                Debug.Log("Grabbed");
                NutritionManager.instance.addTempNutritionAmount(nutrition);
                inHand = true;
            }
        }
        else
        {
            if (inHand)
            {
                Debug.Log("Dropped");
                NutritionManager.instance.subTempNutritionAmount(nutrition);
                inHand = false;
            }
        }
    }
}

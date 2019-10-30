using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity.Interaction;

public class Mouse : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            if (other.gameObject.GetComponent<InteractionBehaviour>().isGrasped)
            {
                NutritionManager.instance.addUpNutritionAmount(other.gameObject.GetComponent<Food>().nutrition);

                // TODO: Play eat sound

                Destroy(gameObject);
            }
        }
    }
}

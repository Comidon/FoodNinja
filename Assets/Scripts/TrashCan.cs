using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCan : MonoBehaviour
{
    private void InstantiateText()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            if (other.transform.parent != null)
            {
                other.transform.parent.GetComponent<Food>().CollectPoints();
            }
            else
            {
                other.GetComponent<Food>().CollectPoints();
            }
        }
    }
}

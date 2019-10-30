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
    private int fadeOutDuration = 300;

    protected List<Material> materials;

    private bool dead = false;


    private Animator anim;

void Start()
    {
        anim = GetComponent<Animator>();
    }

public void CollectPoints()
    {
        // TODO: Collect Points
        // ScoreManager.instance.AddPoints(points);
        Destroy(gameObject);
    }

    private void _FadeOut()
    {
        anim.SetBool("IsDead", true);
        dead = true;

        StartCoroutine(_DoFade());


    }

    private IEnumerator _DoFade()
    {
        int i = fadeOutDuration;

        while (i > 0)
        {
          
            {

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Hover.Core.Items.Types;

public class WeightSelection : MonoBehaviour
{
    private float value = 0;
    public static double weightValue = 80;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //setSlider();
    }
    

    public void setSlider()
    {
        //Debug.Log("before");
        value = (float)GetComponentInParent<HoverItemDataSlider>().SnappedValue;
        weightValue = value * 80 + 20;
        Debug.Log("after Weight:"+weightValue);
    }
    public double getWeight()
    {
        return weightValue;
    }
}

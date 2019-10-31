using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Hover.Core.Items.Types;
using System;
public class AgeSelection : MonoBehaviour
{
    private float value = 0;
    public static decimal ageValue = 17;
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
        ageValue = Math.Round((decimal)(value * 10+8));
        Debug.Log("after age:" + ageValue);
    }
    public decimal getAge()
    {
        return ageValue;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Hover.Core.Items.Types;

public class HeightSelection : MonoBehaviour
{
    private float value = 0;
    public static double heightValue = 170;
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
        float value = (float)GetComponentInParent<HoverItemDataSlider>().SnappedValue;
        heightValue = value * 140 +60;
        Debug.Log("after Height:" + heightValue);
    }
    public double getHeight()
    {
        return heightValue;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts.Utilities;

public class BarController : MonoBehaviour
{
    public Slider bar;
    private float maximum;
    private float currentTotal = 0;

    private void Update()
    {
        float value = currentTotal / maximum * 100;
        bar.value = currentTotal / maximum > 1 ? 100 : currentTotal / maximum * 100;

        Image fill_area = null;
        foreach (Image image in bar.GetComponentsInChildren<Image>())
        {
            if (image.name == "Fill")
            {
                fill_area = image;
            }
        }

        if (value < 90)
        {
            fill_area.color = Color.yellow;
        }
        else if (value >= 90 && value <= 110)
        {
            fill_area.color = Color.green;
        }
        else
        {
            fill_area.color = Color.red;
        }
    }

    public void initialMaximum(float maximum)
    {
        this.maximum = maximum;
    }

    public void changeCurrentTotal(float amount)
    {
        this.currentTotal += amount;
    }

    public float Maximum
    {
        get { return maximum; }
    }

    public float CurrentTotal
    {
        get { return currentTotal; }
    }
}

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
        bar.value = currentTotal / maximum > 1 ? 100 : currentTotal / maximum * 100;
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

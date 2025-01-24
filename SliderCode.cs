//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class SliderCode : MonoBehaviour
{
    public Slider amplitudeSlider;
    public Slider periodSlider;
    private float amplitudeVal;
    private float periodVal;
    int minDimension = 3;

    // Update is called once per frame
    void Update()
    {
        amplitudeVal = amplitudeSlider.value * 10;
        periodVal = periodSlider.value * 10;
        Vector3 scale = new Vector3(Math.Max(periodVal, minDimension), Math.Max(amplitudeVal, minDimension), 2);
        this.transform.localScale = scale;
    }
}

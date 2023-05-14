using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeSlider : BlinkTimer
{
    public Slider slider;
    
    //public float currentBlinkTime;
    public int Smoothing = 2;

    void Update()
    {
        currentBlinkTime = totalBlinkTime;

        if (slider.value != currentBlinkTime)
        {

            slider.value = Mathf.Lerp(slider.value, slider.maxValue - currentBlinkTime, Smoothing + Time.deltaTime); //"slider.maxValue - " ??

        }
    }
}

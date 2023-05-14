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

        if (slider.value != currentBlinkTime)
        {

            slider.value = Mathf.Lerp(slider.value, currentBlinkTime, Smoothing + Time.deltaTime); 
            Debug.Log("whoooo");

        }
    }
}

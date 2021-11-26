using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotacionXY : MonoBehaviour
{
    private Slider scaleSlider;
    private Slider rotateSlider;

    private Slider rotateSliderY; //___
    public float scaleMinValue;
    public float scaleMaxValue;
    public float rotMinValueX;
    public float rotMaxValueX;

    public float rotMinValueY;//___
    public float rotMaxValueY;//___


    void Update() {
        
        scaleSlider = GameObject.Find("SliderR").GetComponent<Slider>();
        scaleSlider.minValue = scaleMinValue;
        scaleSlider.maxValue = scaleMaxValue;

        scaleSlider.onValueChanged.AddListener(ScaleSliderUpdate);


        rotateSlider = GameObject.Find("SliderX").GetComponent<Slider>();
        rotateSlider.minValue = rotMinValueX;
        rotateSlider.maxValue = rotMaxValueX;

        rotateSlider.onValueChanged.AddListener(RotateSliderUpdate_Y);

        
        rotateSliderY = GameObject.Find("SliderY").GetComponent<Slider>();
        rotateSliderY.minValue = rotMinValueY;
        rotateSliderY.maxValue = rotMaxValueY;

        rotateSliderY.onValueChanged.AddListener(RotateSliderUpdate);
        
    }


        

        
    void ScaleSliderUpdate(float value)
    {
        transform.localScale = new Vector3(value, value, value);
    }



    
    void RotateSliderUpdate(float value)
    {
        transform.localEulerAngles = new Vector3(value, transform.rotation.y, transform.rotation.z);
    }


    
    void RotateSliderUpdate_Y(float value)
    {
        transform.localEulerAngles = new Vector3(transform.rotation.x, value, transform.rotation.z);
    }
    
    

    

    


}
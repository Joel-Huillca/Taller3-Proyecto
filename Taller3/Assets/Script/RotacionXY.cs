using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotacionXY : MonoBehaviour
{
    //public float value_R;
    //public Vector3 value_R;
    private Slider scaleSlider;
    private Slider rotateSlider;
    private Slider rotateSliderY;     

//______________valores________________    
    private float scaleMinValue = 0.1f;
    private float scaleMaxValue = 1f;
    private float rotMinValueX = 0f;
    private float rotMaxValueX = 360f;
    private float rotMinValueY = 0f;
    private float rotMaxValueY = 360f;


    void Update() {
        
        
        scaleSlider = GameObject.Find("SliderR").GetComponent<Slider>();
        scaleSlider.minValue = scaleMinValue;
        scaleSlider.maxValue = scaleMaxValue;

        scaleSlider.onValueChanged.AddListener(ScaleSliderUpdate);
        //value_R = scaleSlider;
        //ScaleSliderUpdate(value_R);

        


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
        //value_R = value;
        transform.localScale = new Vector3(value, value, value);
        //Vector3 value_R = new Vector3(value,value,value);
    }



    
    void RotateSliderUpdate(float value)
    {
        transform.localEulerAngles = new Vector3(value, transform.rotation.y, transform.rotation.z);
        //        localEulerAngles = ángulos de Euler locales
    }


    
    void RotateSliderUpdate_Y(float value)
    {
        transform.localEulerAngles = new Vector3(transform.rotation.x, value, transform.rotation.z);
    }
    
    

    

    


}
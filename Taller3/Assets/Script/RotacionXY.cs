using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotacionXY : MonoBehaviour
{
    /*
    private Slider EscalaSlider;
    private Slider RotacionSlider;
    private float valorMinEscala;
    private float valorMaxEscala;
    private float rotMinEscala;
    private float rotMaxEscala;
    */
 
   // we need two sliders
    // we need min and max values of each

    private Slider scaleSlider;
    private Slider rotateSlider;

    private Slider rotateSliderY; //___
    public float scaleMinValue;
    public float scaleMaxValue;
    public float rotMinValueX;
    public float rotMaxValueX;

    public float rotMinValueY;//___
    public float rotMaxValueY;//___



    void Start()
    {
        // find the sliders by name
        //initialize the max and min value when starting
        // Add a listener to the slider when value is changed

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
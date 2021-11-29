using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotacionXY : MonoBehaviour
{
//_____Valor para el tamaño Prefab_____(1)
    public float value_R;

//______________Slider________________(2)     
    private Slider scaleSlider;
    private Slider rotateSlider;
    private Slider rotateSliderY;     

//______________Valores_______________(2)    
    private float scaleMinValue = 0.1f;//         (Escala min)
    private float scaleMaxValue = 1f;//           (Escala max)
    private float rotMinValueX = 0f;//       (Rotación Min - Eje x)
    private float rotMaxValueX = 360f;//     (Rotación max - Eje x)
    private float rotMinValueY = 0f;//       (Rotación min - Eje y)
    private float rotMaxValueY = 360f;//     (Rotación max - Eje y)


    void Update() 
    {
        Escala_Rotacion();   
    }

//___________________________________________________________(2)

    /*Buscamos dentro de Unity el GameObect "nombre_del_objecto" 
    para llamarlo e inicializar sus parametros*/
    void Escala_Rotacion ()
    {
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
        value_R = value;//______________________________________________________(1)
        
        transform.localScale = new Vector3(value, value, value);
        //Vector3 value_R = new Vector3(value,value,value);|
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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*Funciona Para el cambio de altura de acuerdo al Slider*/ 
public class Altura_Prefab : MonoBehaviour
{
    public RotacionXY script_xd;

    void Update()
    {
        float altura_R = script_xd.value_R;
        transform.localScale = new Vector3(altura_R, altura_R, altura_R);
    }
}

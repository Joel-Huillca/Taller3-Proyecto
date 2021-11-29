using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posCubo : MonoBehaviour
{
    /*Posición actulizada del Objecto(Cubo)*/
    public Vector3 posCuboActual;
    public Vector3 posCuboActual_2;
    public GameObject posicionCubeXd2;


    void Update()
    {
        posCuboActual_2 =  posicionCubeXd2.transform.position;
        posCuboActual = transform.localScale;
    }
}

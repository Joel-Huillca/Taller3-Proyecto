using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboInstanciarElementos : MonoBehaviour
{
    public float rangoDeDispercion;
    public Transform posicionCubeXd; //Original
    public GameObject posicionCubeXd2;
    public GameObject[] objecto;

    
    void Update()
    {
        instanciar();
    }


    public void instanciar()
   {
        //  n = Indice generado Aleatoriamente
        int n = Random.Range(0,objecto.Length); //Aleatorio de un rango [cero hasta el largo del arreglo]

        //Ejex & EjesY = de forma aleatoria
        float x = Random.Range(-rangoDeDispercion, rangoDeDispercion);
        float z = Random.Range(-rangoDeDispercion, rangoDeDispercion);


        if(Input.touchCount > 0)
        {
           Touch touch = Input.GetTouch(0);//touch: El primer dedo que toco la pantalla

           if(touch.phase == TouchPhase.Began)
           {
               //posicionCubeXd.transform.x += 0.1f; //solo para un eje
               //Vector3 s = posicionCubeXd.transform.position += new Vector3(x, 0 , z);

               Vector3 s = posicionCubeXd2.transform.position + new Vector3(x, 0.25f , z);

               Instantiate(objecto[n], s ,objecto[n].transform.rotation);
               //Instantiate(objecto[n],     posicionCubeXd.position    ,objecto[n].transform.rotation);//Original
           }

        }   
       

   }
}
    

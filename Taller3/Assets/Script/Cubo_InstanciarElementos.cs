using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo_InstanciarElementos : MonoBehaviour
{
    public float value_R1;
    public float rangoDeDispercion;
    //public Transform posicionCubeXd; //Original
    public GameObject posicionCubeXd2;
    public GameObject[] objecto;
    
    
    void Update()
    {
        instanciar();
        //transform.localScale = new Vector3(value_R1, value_R1, value_R1);
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
               //Vector3 s = posicionCubeXd.transform.position += new Vector3(x, 0 , z);//No funciona tambien se mueve el cubo "+="

               //RotacionXY variable = GetComponent<RotacionXY>(); 
               //float value_R1 = variable.value_R;
               //variable_X = variable.rotateSlider;
               //variable_Y = variable.rotateSliderY;
               
               bool fin = true; 
               while(fin)
               {    
                   
                   if (x != z)
                   {
                        Vector3 posAleatoria = posicionCubeXd2.transform.position + new Vector3(x, 0.25f , z);
               
                        Instantiate(objecto[n],  posAleatoria  ,objecto[n].transform.rotation);

                        fin =false; 
                   }
                   x = Random.Range(-rangoDeDispercion, rangoDeDispercion);
                   z = Random.Range(-rangoDeDispercion, rangoDeDispercion);

               }
               

               //Vector3 posAleatoria = posicionCubeXd2.transform.position + new Vector3(x, 0.25f , z);
               
               //Instantiate(objecto[n],  posAleatoria  ,objecto[n].transform.rotation);

               //Instantiate(objecto[n],  posAleatoria  ,objecto[n].transform.rotation);//Funciona bien, solo para la escala del cuadrado
               //Instantiate(objecto[n],     posicionCubeXd.position    ,objecto[n].transform.rotation);//Original
               
           }

        }   
       

   }
}
    

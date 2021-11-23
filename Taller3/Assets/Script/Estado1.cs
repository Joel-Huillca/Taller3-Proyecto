

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class Estado1 : MonoBehaviour
{
    public GameObject objectPrefab;
    public GameObject indicator;
    public Renderer cubeRenderer;
    public GameObject[] objectsX;

    void Update()
    {
        SpawnnPrefab(); 
        PlayerInputs();
    }

 
 
    public void SpawnnPrefab()  //++
   {
       if(Input.touchCount > 0)
       {
           Touch touch = Input.GetTouch(0);//touch: El primer dedo que toco la pantalla

           if(touch.phase == TouchPhase.Began)
           {    
               if (indicator.activeInHierarchy == true)//Instanciamo un elemento si tenemos un punto valido
               {
                   Instantiate(objectPrefab, this.transform.position, this.transform.rotation);
                   //ObjetPrefab = Es el objeto que se esta movimiendo a medida que vamos apuntando con nuestro celular
               }
           }
       }
   }

public void SetRandomColor()
    {
        int randmIndex = Random.Range(0,objectsX.Length);
        //cubeRenderer.material.color = objectsX[randmIndex];
        
    }

    public void PlayerInputs()
    {
        //Verificamos si esta tocando la pantalla
        if (Input.touchCount > 0)
        {
            //Obtenemos un touch a travez de su indice
            Touch touch = Input.GetTouch(0);

            //Preguntamos por la fase del touch
            if (touch.phase == TouchPhase.Began)
            {
                //Creamos un rayo con punto inicial = La posición del touch
                Ray ray = Camera.main.ScreenPointToRay(touch.position);

                //Este RaycastHit almaceba el resultado del rayo
                RaycastHit hit;

                //Si el rayo toca algo se retorna true
                if (Physics.Raycast(ray, out hit) == true)
                {
                    SetRandomColor();
                }

            }
        }
    }


}







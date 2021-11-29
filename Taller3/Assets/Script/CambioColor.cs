using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColor : MonoBehaviour
{
    /*Camcio de color (touch) para un objecto*/
    public Renderer cubeRenderer;

    public Color[] colors; //Se almacena los Colores, los colores aleatorios que se iran colocando

    private void Update() 
    {
     PlayerInputs();
    }


    public void SetRandomColor()
    {
        int randmIndex = Random.Range(0,colors.Length);
        cubeRenderer.material.color = colors[randmIndex];
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

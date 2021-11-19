using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Importar Librerias ARFundation
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;


public class DeteccionPlano : MonoBehaviour
{

    public ARRaycastManager aRRaycastManager;
  
    public GameObject indicator;  //Puntero lacer (Rayo) Indicador de posición
    
    public GameObject objectPrefab; //Un prefab de lo que queramos instanciar en la ECENA

    private void Update() 
    {
        PlaneDetection(); 

        SpawnnPrefab(); 
    }

    //_____________________:::::________________________

    //Detección de Planos
    public void PlaneDetection()
    {
        /*LANZAR UN RAYO DESDE EL CENTRO DE LA PANTALLA*/
        List<ARRaycastHit> hits = new List<ARRaycastHit>();//Lista donde se guardan los rayos
        
        Vector2 screenPosition = new Vector2 (Screen.width / 2, Screen.height / 2);//Ancho y largo de pantalla(ancho/2 , Altura/2 )

        aRRaycastManager.Raycast(screenPosition, hits, TrackableType.Planes);
        
        /*SI EL RAYO TOCA UN PLANO ACTIVAMOS EL INDICADOR PARA ALERTAR AL USUARIO*/
        if(hits.Count > 0)
        {
            this.transform.position = hits[0].pose.position;
            this.transform.rotation = hits[0].pose.rotation;

            indicator.SetActive(true);//Activamos el rayo
        }
        else
        {
            indicator.SetActive(false);//Si no encuentra un plano valido, se desactiva el rayo
        }
    }

    //_____________________:::::________________________


    /*CUANDO HACEMOS CLIK en la panatalla, INSTANCIAMOS UN OBJETO _-_*/
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


}
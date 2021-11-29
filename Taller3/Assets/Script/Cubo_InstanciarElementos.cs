using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo_InstanciarElementos : MonoBehaviour
{

    /*Matthew se hizo lo que se pudo, pero fue con cariño xd*/



    /*Se instancia un prefab al azar con respecto al touch (sonido incluido)*/



    //__________Modo prueba 1__________
    //public ActivadoPanel script_activado_Panel;

    //public bool activado_Panel;

    //_____________posCubo____________
    
    //public posCubo script_posCubo;
    //public Vector3 posCube_;
    //________________________________
    public GameObject audio_2;
    public InstanciarUnObjectoAlTocarlo script_Insta;
    
    public RotacionXY script_xd;

    //_____Solo cuando el panel este abierto______
    public GameObject panel_Elemnt_;
    
    //____________________________________________
    public float value_R1;
    public float rangoDeDispercion;
    //public Transform posicionCubeXd; //Original
    public GameObject posicionCubeXd2;

   //___________________________________________
    public GameObject[] arboles;
    public GameObject[] rocas;
    public GameObject[] decoraciones;

    private int n ; //Numero aleatorio
    private int n1 ; //
    //___________________________________________
    public GameObject[] objecto;

    //public List<GameObject> objecto;
    //public GameObject[][] objecto;
 //_____________________________________
    
    private void Awake() 
    {// Comienza antes que el Start 
        audio_2.SetActive(false);
    }
    
    void Update()
    {
        instanciar();
        //aleatorioInstanciar();
    }

    public void aleatorioInstanciar()
    {
        
        
        //  n = Indice generado Aleatoriamente
        //int n = Random.Range(0,objecto.Length); //Aleatorio de un rango [cero hasta el largo del arreglo]
       
        /*int n1 = Random.Range(0,objecto.Length);
        int n2 = Random.Range(0,objecto.Length);


        objecto[n][n1] = arboles[n];
        objecto[n][n1] = rocas[n];
        objecto[n][n1] = decoraciones[n];*/

        int n1 = Random.Range(0,2);
        // (0) ->Arboles
        // (1) ->Rocas
        // (2) ->Decoraciones

        switch(n1)
        {
            case 0:
                n = Random.Range(0,arboles.Length);
                n1 = 0;
                objecto[n1]=arboles[n];  //  3
                instanciar();
                break;
            case 1:
                n = Random.Range(0,rocas.Length);
                n1 = 1;
                objecto[n1]=rocas[n];
                instanciar();
                break;
            case 2:
                n = Random.Range(0,1);
                n1 = 2;
                objecto[n1]=decoraciones[1];
                instanciar();
                break;
            default:
                n = Random.Range(0,1);
                n1 = 2;
                objecto[2]=decoraciones[n];
                instanciar();
                break;
        }
    }

    public void instanciar()
    {
        audio_2.SetActive(false);

        
        int n_ = Random.Range(0,objecto.Length); //Aleatorio de un rango [cero hasta el largo del arreglo]

        //Ejex & EjesY = de forma aleatoria
        float x = Random.Range(-rangoDeDispercion, rangoDeDispercion);
        float z = Random.Range(-rangoDeDispercion, rangoDeDispercion);

        value_R1 = script_xd.value_R;
        //float x = Random.Range(value_R1, value_R1);
        //float z = Random.Range(value_R1, value_R1);

        //if(panel_Elemnt_ == true && script_activado_Panel.activado_PANEL_ == true && script_activado_Panel.pestanaElement == true)
        if(panel_Elemnt_)
        {        
            
            if(Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);//touch: El primer dedo que toco la pantalla

                

                if(touch.phase == TouchPhase.Began  )
                {  
                    //posicionCubeXd.transform.x += 0.1f; //solo para un eje
                    //Vector3 s = posicionCubeXd.transform.position += new Vector3(x, 0 , z);//No funciona tambien se mueve el cubo "+="

                    //RotacionXY variable = GetComponent<RotacionXY>(); 
                    //float value_R1 = variable.value_R;
                    //variable_X = variable.rotateSlider;
                    //variable_Y = variable.rotateSliderY;
               
                //    if(panel_Elemnt_)
                //{//*********
                    bool fin = true; 
                    while(fin)
                    {    
                        
                        if (x != z)
                        {
                        //Vector3 posAleatoria = posicionCubeXd2.transform.position + new Vector3(x, value_R1/2 , z);       //Funciona en el objecto del cubo 

                        Vector3 posAleatoria = script_Insta.placementIndicator.transform.position + new Vector3(x, value_R1*3 , z);

                        //Vector3 posAleatoria = script_Insta.objectToPlace.transform.position + new Vector3(x, value_R1 , z);

                        //Vector3 posAleatoria = script_posCubo.posCuboActual_2 + new Vector3(x, value_R1 , z);
               
                        Instantiate(objecto[n_],  posAleatoria  ,objecto[n_].transform.rotation);

                        
                        
                        audio_2.SetActive(true);

                        Instantiate(audio_2);
                        
                        

                        fin =false; 
                        }
                        x = Random.Range(-rangoDeDispercion, rangoDeDispercion);
                        z = Random.Range(-rangoDeDispercion, rangoDeDispercion);
                    }
               
                //}//*********

                    //Vector3 posAleatoria = posicionCubeXd2.transform.position + new Vector3(x, 0.25f , z);
               
                    //Instantiate(objecto[n],  posAleatoria  ,objecto[n].transform.rotation);

                    //Instantiate(objecto[n],  posAleatoria  ,objecto[n].transform.rotation);//Funciona bien, solo para la escala del cuadrado
                    //Instantiate(objecto[n],     posicionCubeXd.position    ,objecto[n].transform.rotation);//Original
               
                }

            }   
        }// Fin__

       
    }
}
    

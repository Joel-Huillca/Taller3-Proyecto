using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objecto_Desac_Activ : MonoBehaviour
{
    //public GameObject objectoActivaDesact;
    public GameObject objectoActivado1;
    public GameObject objectoDesactivado2;
    public GameObject objectoDesactivado3;
    public GameObject objectoDesactivado4;
   
    void Start()
    {
        objectoActivado1.SetActive(true);
        objectoDesactivado2.SetActive(false);
        objectoDesactivado3.SetActive(false);
        objectoDesactivado4.SetActive(false);
    }

 
    void Update()
    {
    /*
        if(Input.GetKeyDown(KeyCode.A)){ //Desparce el objeto apretando la letra "A"
            objectoActivaDesact.SetActivate(false);
        }
        if(Input.GetKeyDown(KeyCode.D)){//Aparece el objeto apretando la letra "D"
            objectoActivaDesact.SetActivate(true);
        }
    */






    }
}

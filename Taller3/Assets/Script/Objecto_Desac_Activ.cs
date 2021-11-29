using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objecto_Desac_Activ : MonoBehaviour
{
    /*Desactivamos los objetos que nos interrumpen en el inicio del MENU*/
    public GameObject objectoActivado1;
    public GameObject objectoDesactivado2;
    public GameObject objectoDesactivado3;
    public GameObject objectoDesactivado4;
    public GameObject objectoDesactivado5;
   
    void Start()
    {
        objectoActivado1.SetActive(true);
        objectoDesactivado2.SetActive(false);
        objectoDesactivado3.SetActive(false);
        objectoDesactivado4.SetActive(false);
        objectoDesactivado5.SetActive(false);
    }

}

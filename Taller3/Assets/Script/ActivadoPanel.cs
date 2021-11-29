using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Esto fue diseñado en 1era estancia para mandar
//un bool si esta activado o no el panel de instaciar objectos
public class ActivadoPanel : MonoBehaviour
{
    public GameObject pestanaElement;
    public GameObject boton5;
    public GameObject panel;
    public bool activado_PANEL_;
    void Update()
    {
        if (panel == true)
        {
            activado_PANEL_=true;
        }
        if (panel == false)
        {
            activado_PANEL_=false;
        }
        
        if (boton5 == false)
        {
            activado_PANEL_ = false;
        }

        if (pestanaElement == false)
        {
            activado_PANEL_ = false;
        }

    }
}

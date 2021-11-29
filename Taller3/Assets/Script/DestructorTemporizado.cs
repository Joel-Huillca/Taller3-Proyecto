using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructorTemporizado : MonoBehaviour
{
    /*Destruye el objecto luego de un tiempo determinado*/
    public float tiempoDeVida;
     void Start()
    {
        Destroy(gameObject,tiempoDeVida);
    }

    
    void Update()
    {
        
    }
}

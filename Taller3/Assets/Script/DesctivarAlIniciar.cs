using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesctivarAlIniciar : MonoBehaviour
{

    public GameObject Object1;
    public GameObject Object2;
    public GameObject Object3;
    public GameObject Object4;
  


    
    void Start()
    {
        Object1.SetActive(false);   
        Object2.SetActive(false); 
        Object3.SetActive(false); 
        Object4.SetActive(false);     
    }

}

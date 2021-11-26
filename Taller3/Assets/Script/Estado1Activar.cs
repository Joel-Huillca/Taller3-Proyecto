using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estado1Activar : MonoBehaviour
{

    //public GameObject objectoActivarCube;
    public GameObject objectoActivar0;
    public GameObject objectoActivar1;
    public GameObject objectoActivar2;
    public GameObject objectoActivar3;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (objectoActivar0 == true)
        {
            objectoActivar1.SetActive(true);
            objectoActivar2.SetActive(true);
            objectoActivar3.SetActive(true);
        }
    }
}

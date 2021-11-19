using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase8 : MonoBehaviour
{

    public float xAngle;
    public float yAngle;
    public float zAngle;
    public float scale;
    public Vector3[] noseQuePoner;
    public GameObject objecto;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScaleGameObject_1(scale);
        //ScaleGameObject_2(scale);
        Rotate(xAngle,yAngle,zAngle);
        
    }

/*_________________________CÓMO ESCALAR UN ELEMENTO_________________________*/
    public void ScaleGameObject_1(float scale)
    {
        //Esta son dos alternativas para Usar: (1) y (2)
        this.transform.localScale = Vector3.one*scale; //(1)
        this.transform.localScale = new Vector3(scale,scale,scale); //(2)
    }

    public void ScaleGameObject_2(Vector3 scale) 
    {
        //Esta forma tambien es valida
        this.transform.localScale = scale;
    }

    /*_______________________CÓMO ROTAR UN ELEMENTO_______________________*/

    public void Rotate(float xAngle, float yAngle, float zAngle)
    {
        //Rota un GameObject con respecto a la secena
        this.transform.eulerAngles = new Vector3(xAngle,yAngle,zAngle);

        //Rota un GameObject con respecto a su padre
        this.transform.localEulerAngles = new Vector3(xAngle,yAngle,zAngle);
    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarV1 : MonoBehaviour
{
    public float xAngle;
    public float yAngle;
    public float zAngle;
    
    
    void Update()
    {
        Rotate(xAngle,yAngle,zAngle);
    }

     public void Rotate(float xAngle, float yAngle, float zAngle)
    {
        //Rota un GameObject con respecto a la secena
        this.transform.eulerAngles = new Vector3(xAngle,yAngle,zAngle);

    }
}

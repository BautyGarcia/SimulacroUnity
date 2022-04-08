using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ1 : MonoBehaviour
{
    // Start is called before the first frame update
    /*
    Crea un programa que permita ingresar por Inspector dos valores enteros y responda si son iguales o no lo son.
    */
    public int Num1;
    public int Num2;
    void Start()
    {
        if (Num1 == Num2){
            Debug.Log("Los valores son iguales");
        }else{
            Debug.Log("Los valores no son iguales");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

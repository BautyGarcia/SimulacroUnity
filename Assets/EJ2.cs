using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ2 : MonoBehaviour
{
    /*
    Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible.
    Comunicar si la suma de los mismos supera o no el monto de dinero disponible. Luego indicar cuánto dinero sobra o falta.
    */
    // Start is called before the first frame update
    public int Precio1;
    public int Precio2;
    public int Precio3;
    public int MontoDinero;
    void Start()
    {
        if (MontoDinero > Precio1+Precio2+Precio3){
            MontoDinero -= Precio1;
            MontoDinero -= Precio2;
            MontoDinero -= Precio3;
            Debug.Log("El monto de dinero disponible supera al necesario. Sobran: "+MontoDinero+"$");
        }else{
            Precio1 += Precio2;
            Precio1 += Precio3;
            Precio1 -= MontoDinero;
            Debug.Log("El monto de dinero disponible no supera al necesario. Faltan: "+Precio1+"$");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

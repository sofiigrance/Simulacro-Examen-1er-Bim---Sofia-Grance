using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeladeriaLosTresGustos : MonoBehaviour
{

    //1. Definición de variables

    public string codigoHelados;
    public int cantidadGramos;
    float costoHelados;

    void Start()
    {
        //2. Validació de datos 

        if (cantidadGramos < 250 || cantidadGramos > 3000)
        {
            Debug.Log("Error al ingresar la cantidad de gramos.");
            return;
        }

        if (codigoHelados != "CHO" && codigoHelados != "DDL" && codigoHelados != "FRU")
        {
            Debug.Log("Codigo no valido");
            return;
        }

        //3. Procesamiento de datos

        costoHelados = cantidadGramos * 1250 / 1000f;

        if (codigoHelados == "FRU")
        {
            costoHelados = costoHelados * 0.9f;
        }

        //4. Salida de datos 

        Debug.Log("Debe abonar $" + costoHelados);

    }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

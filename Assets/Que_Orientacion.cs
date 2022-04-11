﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Que_Orientacion : MonoBehaviour
{
    public string nombreAlumno, orientacion;
    public int anio;
    

    void Start()
    {
       
        
        //Mostrar un mensaje de error si el nombre ingresado es una cadena de caracteres vacía y si el año ingresado 
        //no está en el rango del 1 al 5. 
        if (nombreAlumno== "") {
            Debug.Log("Error. Ingrese un nombre válido");
    
        }

        else if (anio < 1 || anio > 5)
        {
            Debug.Log("Error. Ingrese números entre 1 y 5");
        }



       // Si se ingresa un valor diferente a las opciones válidas en el campo ingreso de orientación escribir en consola 
       //“Solo puede ingresar T, D, G, M o H”.
        else if (orientacion != "T" ||orientacion != "D" || orientacion != "G" || orientacion != "M"|| orientacion != "H")
        {
            Debug.Log("Solo puede ingresar T, D, G, M o H");
        }


        //Si el año ingresado no está entre 3 y 5 se debe mostrar el mensaje “Error. Aún estás en el ciclo básico”
        else if (anio<3 && anio>1)
        {
            Debug.Log("Error. Aún estás en el ciclo básico");
        }

        else
        {
            Debug.Log("Muchas gracias " + nombreAlumno + "!");
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

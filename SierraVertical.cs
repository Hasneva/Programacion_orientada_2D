using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Nombre del desarrollador: Mariana Hasneva Vazquez Rebollo
Asignatura: Programación orientada a objetos
Profesor: Josue Israel Rivas Diaz
Script: Sierra: Cerebro
Descripcion: Asigna de manera vertical la sierra.*/
public class SierraVertical : Cerebro
{
    // Start is called before the first frame update
    void Start()
    {
        initialPos = transform.position; //la posicion inicial es igual a la posición del objeto de la escena
    }

    // Update is called once per frame
    void Update()
    {

        MovimientoSin(this.gameObject.transform); //asignar la función a las propiedades del objeto del juego

        Rotacion(this.gameObject.transform); //asignar la función a las propiedades del objeto del juego para rotar 
    }

    protected override void MovimientoSin(Transform t)
    {
        SenoPos = new Vector3(0, Mathf.Sin(Time.time * velocidad) * distancia, 0); //se declara el movimiento en el eje equis por medio de la función matemática del Seno
        base.MovimientoSin(t); //funcion del seno 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Nombre del desarrollador: Mariana Hasneva Vazquez Rebollo
Asignatura: Programación orientada a objetos
Profesor: Josue Israel Rivas Diaz
Script: Sierra: Cerebro
Descripcion: Controla el movimiento de las sierra así como su color.*/

public class Sierra : Cerebro
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

        Rotacion(this.gameObject.transform);//asignar la función a las propiedades del objeto del juego para rotar 

        CambiarColor(obstaculoSprite, colorSprite); //cambiar color de acuerdo al condicionante 


    }

    protected override void MovimientoSin(Transform t) //función que declara la acción de Sin
    {
        SenoPos = SenoPos = new Vector3(Mathf.Sin(Time.time * velocidad) * distancia, 0, 0); //se declara el movimiento en el eje equis por medio de la función matemática del Seno
        base.MovimientoSin(t); //funcion del seno 
    }
}

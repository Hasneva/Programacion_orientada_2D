using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Nombre del desarrollador: Mariana Hasneva Vazquez Rebollo
Asignatura: Programación orientada a objetos
Profesor: Josue Israel Rivas Diaz
Script: Sierra: Cerebro
Descripcion: Controla el movimiento de las sierra así como su color.*/

public class SierraSeguidora : Cerebro
{

    void Update()
    {
        MovimientoSin(this.gameObject.transform); //asignar la función a las propiedades del objeto del juego

    }

    protected override void MovimientoSin(Transform t) //función que declara la acción de Sin
    {
        t.position = Vector2.MoveTowards(t.position, target.transform.position, velocidad); //posición del objeto que apartir de la mimsa, se mueve en dirección a mi objetivo, mediante la velocidad
    }

    private void OnTriggerEnter2D(Collider2D collision) //función que detecta las colisiones en segunda dimensión
    {
        if (collision.gameObject.tag == "Player")//condicionte que detecta la colisión en el tag del objeto
        {
            CambiarColor(obstaculoSprite, colorSprite); //cambiar color de acuerdo al condicionante 
        }
    }
}

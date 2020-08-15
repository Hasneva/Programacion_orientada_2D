using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Nombre del desarrollador: Mariana Hasneva Vazquez Rebollo
Asignatura: Programación orientada a objetos
Profesor: Josue Israel Rivas Diaz
Script: Sierra: Cerebro
Descripcion: Controla el movimiento de las sierra así como su color.*/
public class SierraAtaque : Cerebro
{
    void Start()
    {
        initialPos = transform.position; //la posicion inicial es igual a la posición del objeto de la escena

    }

    // Update is called once per frame
    void Update()
    {
        MovimientoSin(this.gameObject.transform); //asignar la función a las propiedades del objeto del juego

        //Rotacion(this.gameObject.transform);
    }

    protected override void MovimientoSin(Transform t) //función que declara la acción de Sin
    {
        t.Translate(Vector2.right * -velocidad * Time.deltaTime); //permite la trasladación del objeto a la derecha 
    }


    private void OnCollisionEnter2D(Collision2D collision) //función que detecta las colisiones en segunda dimensión
    {

        if (collision.gameObject.tag == "Player") //condicionte que detecta la colisión en el tag del objeto
        {
            DañoJugador(); //objeto que daña a nuestro player asignado
            CambiarColor(obstaculoSprite, colorSprite); //cambia el color de nuestro objeto
            Debug.Log(collision.gameObject.name); //manda mensaje a la consola con la intensión de mostrar la colisión con el objeto de juego
        }
    }

}

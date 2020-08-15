//Nombre de desarrollador: Sardinas Tinoco Sofia Edith
//Asignatura:Programacion Orientada a Objetos
//Profesor:Josue Israel Rivas Diaz
//Nombre de código:Player2
//Descripción: Controles, datos de un segundo juador y registro de animaciones

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    //Cambia el Bob por Luc por ser personajes distintos, pero en realidad todo puede quedar igual ya que cada uno esta encapsulado

    public ConstructorPersonaje Fairy = new ConstructorPersonaje();
    //permiten la activacion correcta de las animaciones del personaje y le agrega cualidades fisicas como la gravedad.
    Animator animarFairy;
    SpriteRenderer spriteFairy;
    Rigidbody2D fisicasRB2D;

    // Start is called before the first frame update
    void Start()
    {
        #region datos del personaje y animacion
        //asignacion de datos base
        //++++++++++++++++Datos de Personaje++++++++++++++++++

        Fairy.nombre = "Fairy";
        gameObject.name = Fairy.nombre;
        Fairy.vida = 20;
        Fairy.daño = 50;
        //++++++++++++++++++++++++++++++++++

        //+++++++++++Inicializacion de componentes+++++++++

        //Interfaz para controlar el sistema de animación.
        animarFairy = GetComponent<Animator>();
        //Representa un Sprite para gráficos 2D.
        spriteFairy = GetComponent<SpriteRenderer>();
        //Agrega un control de fisicas (gravedad)(funciona de manera similar al rigidbody3d)
        fisicasRB2D = GetComponent<Rigidbody2D>();

        //++++++++++++++++++++++++++++++++++
        #endregion
    }


    // Update is called once per frame
    void Update()
    {
        
        //Llamas a lo que quieres utilizar de Luc/Bob (constructor del personaje).
        //Decidi cambiar "Velocidad" por "Avance" para que fuera mas notoria la diferencia entre personajes.
        //flip.X gira el sprite en el eje de X para voltear a la izquierda y a la derecha
        //Playanimation reproduce una animacion si mezclarla con otra (pasar de la respiracion al movimiento)

        #region movimiento Lucas
        if (Input.GetKey(KeyCode.D))
        {
            Fairy.Movimiento(fisicasRB2D, 3f);
            animarFairy.SetBool("Velocidad", true);
            spriteLucas.flipX = false;
        }

        else if (Input.GetKey(KeyCode.A))
        {
            Fairy.Movimiento(fisicasRB2D, -3f);
            animarFairy.SetBool("Velocidad", true);
            spriteFairy.flipX = true;
        }

        else
        {
            animarFairy.SetBool("Velocidad", false);
        }
        #endregion
    }
}

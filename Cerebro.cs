/*




*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cerebro : MonoBehaviour
{
    // Start is called before the first frame update
    //Protected: solo el codigo heredado puede manipularlo o cambiarlo, mientras esta protegido como si fuera un private
    
    public Vector3 initialPos;
    public float Velocidad;
    //Distancia que recorren
    public float Distancia;
    public float VelocidadRotacion;
    private Vector3 senoPos;
    //Se asigna el objetivo para seguirlo
    protected Transform target;
    public SpriteRenderer obstaculoSprite;
    //Cambiar el sprite de color
    public Color colorSprite;
    //Daño que provocan
    public int daño;
    public Player1 player;

    //La libreria Math se encarga de las funciones matematicas (Seno, Coseno, Tangente, Clamp y Absoluto)
    protected Vector3 SenoPos
    {
        //get/set:permite exponer datos de un tipo que parece un campo cuando accede a él, pero actúa como un par de funciones en las que puede ejecutar el comportamiento cada vez que se lee la propiedad 
        get
        {
            return senoPos;
        }
        set
        {
            senoPos = value;
        }
    }
    private void Start()
    {
        //Busca al objeto con el tag player y lo fija como objetivo
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        
    }

    //Permite el movimiento vertical desde un punto inicial.
    protected virtual void MovimientoSin(Transform t)
    {
        Vector3 sPos = SenoPos;
        t.position = initialPos + sPos;
    }

    //Hace que rote sobre su eje el sprite
    protected void Rotacion(Transform t)
    {
        t.Rotate(Vector3.forward*VelocidadRotacion);
    }

    //cambia el color del sprite
    protected virtual void CambiarColor (SpriteRenderer o, Color c)
    {
        o.GetComponent<SpriteRenderer>().material.color = c;
    }


    protected virtual void DañoJugador()
    {
         //Calculodaño = Velocidad * 2;
        player.Bob.vida -= daño;
    }
}

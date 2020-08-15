using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Nombre del desarrollador: Mariana Hasneva Vazquez Rebollo
Asignatura: Programación orientada a objetos
Profesor: Josue Israel Rivas Diaz
Script: Enemigo.
Descripcion: Asigna parametros de vida y daño a los enemigos.*/

public class Enemigo : MonoBehaviour
{
    //Se manda a llamar el Constructor personaje y se le asigna un nombre | Pala es un nuevo objeto deribado de Constructor personaje 
    public ConstructorPersonaje pala = new ConstructorPersonaje();
    public ConstructorPersonaje camionCons = new ConstructorPersonaje(); //ConstructorPersonaje es un nuevo Objeto

    public GameObject camionObjeto; //Representa el objeto en unity
    public GameObject palaObjeto; 

    // Start is called before the first frame update
    void Start()
    {
       //Se manda a hacer una busqueda del objeto gameObject con el nombre "Enemigo1" dentro de Unity
        palaObjeto = GameObject.Find("Enemigo1");

        //Encontrar dentro de Unity un objeto con el nombre "Enemigo2"

        camionObjeto = GameObject.Find("Enemigo2");

        //-----------------------------------------

        camionCons.nombre = "Camion_Malo"; // El objeto "CamionCons" va a tener el siguiente nombre 
        camionObjeto.name = camionCons.nombre; //Al objeto en unity se le va a asignar el nombre Camion_Malo
        camionCons.vida = 20; //Se le asgina a camionCons un Valor de vida 
        camionCons.daño = 5;

        //------------------------------------------
       
        pala.nombre = "Pala"; // El objeto "Pala" va a tener el siguiente nombre 
        palaObjeto.name = pala.nombre; //Al objeto en unity se le va a asignar el nombre pala 
        pala.vida = 20;
        pala.daño = 2; 

        //------------------------------------------

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

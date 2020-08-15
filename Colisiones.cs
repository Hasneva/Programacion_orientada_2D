using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Nombre del desarrollador: Mariana Hasneva Vazquez Rebollo
Asignatura: Programación orientada a objetos
Profesor: Josue Israel Rivas Diaz
Script: Colisiones
Descripcion: Encuentra el componente asignado y regritra colision.*/

public class Colisiones : MonoBehaviour
{
    [SerializeField] //SerializeField declaracion de variables que pueden ser vistas desde el inspector 
    string[] nombreObj; //Genera la info de la etiqueta con la que se esta colisionando.

    [SerializeField]
    string[] mensaje; //String para mandar un mensaje al detectarse la colision

    //Metodo para poder reciclar con diferentes objetos
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var EncontrarBob = GetComponentInParent<Player1>(); //Variable local que trae la info de Player1 | GetComponentInParent: Limita la busqueda a un componente hijo que ya existe en PlayerDino.
        EncontrarBob.Bob.RegistroColision(collision, "DINO"); //Se llama al objeto Bob y RegistroColision y se le indica que version del metodo se utilizara.
    }
}

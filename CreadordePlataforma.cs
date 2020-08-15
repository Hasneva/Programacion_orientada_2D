using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Nombre del desarrollador: Mariana Hasneva Vazquez Rebollo
Asignatura: Programación orientada a objetos
Profesor: Josue Israel Rivas Diaz
Script: Sierra: Creador Plataforma
Descripcion: invocar plataforma.*/
public class CreadordePlataforma : MonoBehaviour
{

    public GameObject plataforma; //objeto asignado como plataforma
    public Transform startPosition; //posición inicial de la plataforma
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreacionPlataforma", 0, 3f); //invocar plataforma en una posicón
    }

    // Update is called once per frame
    void CreacionPlataforma() //crear plataforma
    {
        Instantiate(plataforma, startPosition.position, startPosition.rotation); //instanciar plataformas en una posición inicial 
    }
}

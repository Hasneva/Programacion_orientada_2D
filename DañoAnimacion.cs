using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Nombre del desarrollador: Mariana Hasneva Vazquez Rebollo
Asignatura: Programación orientada a objetos
Profesor: Josue Israel Rivas Diaz
Script: Sierra: Cerebro
Descripcion: Decreta cuantas vidas tiene el player antes de su destrucción total.*/
public class DañoAnimacion : MonoBehaviour
{
    Player1 playervida; //asigna las vidas de player
    public int daño; //daño al player

    // Start is called before the first frame update
    void Start()
    {
        playervida = FindObjectOfType<Player1>(); //encontar el objeto al que se le tienen que restar vidas
    }

    // Update is called once per frame
    void Daño()
    {
        playervida.Bob.vida -= daño; //daño completo al player así para destruirlo
    }
}

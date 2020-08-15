using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Nombre del desarrollador: Mariana Hasneva Vazquez Rebollo
Asignatura: Programación orientada a objetos
Profesor: Josue Israel Rivas Diaz
Script: Traslacoón con una velocidad de un objeto.
Descripcion: Le da movimiendo al Player1 y activa los sprites, le da registro a la vida y daño.*/
public class TrasladarPlataforma : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * 5f * Time.deltaTime); //permite la trasladación del objeto hacia la izquierda multiplicado por el valor asignado
    }
}

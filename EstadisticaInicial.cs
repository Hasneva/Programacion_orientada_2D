
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

/*Nombre del desarrollador: Mariana Hasneva Vazquez Rebollo
Asignatura: Programación orientada a objetos
Profesor: Josue Israel Rivas Diaz
Script: EstadisticaInicial
Descripcion: Valores iniciales.
*/

public class EstadisticaInicial : MonoBehaviour
{

    public InputField campoNombre;

    // Start is called before the first frame update
    void Start()
    {
        //Se puede acceder a las variables publicas de GameManager
        GameManager.Instance.nombrejugador = campoNombre.text;
    }

    // Update is called once per frame
    void Update()
    {
        GameManager.Instance.nombrejugador = campoNombre.text;
    }
}

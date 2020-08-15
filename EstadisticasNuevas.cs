using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Nombre del desarrollador: Mariana Hasneva Vazquez Rebollo
Asignatura: Programación orientada a objetos
Profesor: Josue Israel Rivas Diaz
Script: EstadisticasNuevas
Descripcion: Cambia valores de las variables.
*/
public class EstadisticasNuevas : MonoBehaviour
{
    public Transform playerposition;


    // Start is called before the first frame update
    void Start()
    {
        playerposition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();


        //Ya que tiene asignados y cargados los valores que estas guardando en las posiciones flotantes, le asiga las posiciones al jugador
        if (GameManager.Instance.checkpointPosition != Vector3.zero)
        {
            playerposition.position = GameManager.Instance.checkpointPosition;
        }
        GameManager.Instance.nombrejugador = PlayerPrefs.GetString("nombreJ");
    }

    // Update is called once per frame
    void Update()
    {
        //Posiciones en las que el jugador iniciara, asi este no empezara donde se haya quedado antes, este es una posicion fija
        GameManager.Instance.puntosposicion[0] = playerposition.position.x;
        GameManager.Instance.puntosposicion[1] = playerposition.position.y;
        GameManager.Instance.puntosposicion[2] = playerposition.position.z;
    }

    public void Guardar()
    {
        GameManager.Instance.GuardarJuego();
    }
}

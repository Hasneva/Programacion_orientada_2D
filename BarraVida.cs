using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*Nombre del desarrollador: Mariana Hasneva Vazquez Rebollo
Asignatura: Programación orientada a objetos
Profesor: Josue Israel Rivas Diaz
Script: BarraVida
Descripcion: Asigna al player.*/

public class BarraVida : MonoBehaviour

{

    public Slider barraVida; //barra asignada para la barrita
    public int vidaPlayer; //asigna el valor de la vida

    // Start is called before the first frame update
    void Start()
    {
        vidaPlayer = Player1.vidaPlayer; //asigna el valor de la vida
        barraVida.maxValue = vidaPlayer; //valor maximo es igual a la vida que tiene el jugador
        barraVida.value = vidaPlayer; //valor actual de la vida que tiene el jugador
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) //realiza la acción cuando se presiona la tecla 1
        {
            vidaPlayer -= 10; //vidas asignadas que se disminuye en un valor de 10
        }

        barraVida.value = vidaPlayer; //se actualiza el valor de la vida del jugador 
    }
}

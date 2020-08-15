using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Nombre del desarrollador: Mariana Hasneva Vazquez Rebollo
Asignatura: Programación orientada a objetos
Profesor: Josue Israel Rivas Diaz
Script: Sierra: Cerebro
Descripcion: Asigna animaciones al enemigo.*/
public class EstadoZombie : CerebroEnemigo
{


    // Start is called before the first frame update
    void Start()
    {
        EnemigoSprite = GetComponent<SpriteRenderer>(); //obtiene el compente del render del sprite
        AnimZombie = GetComponent<Animator>(); //componente asignado al animator que manda información a la consola 
        Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>(); //asgina el objetivo del enemigo mediante su tag
        Velocidad = 1f; //asgina el valor de velocidad
    }

    // Update is called once per frame
    void Update()
    {
        Perseguir(this.transform); //cambio de estado al perseguir.
    }
}

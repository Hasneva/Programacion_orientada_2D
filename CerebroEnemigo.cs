using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Nombre del desarrollador: Mariana Hasneva Vazquez Rebollo
Asignatura: Programación orientada a objetos
Profesor: Josue Israel Rivas Diaz
Script: Sierra: Cerebro Enemigo
Descripcion: Donde controla las sierras de manera directa.*/
public class CerebroEnemigo : MonoBehaviour
{
    protected float velocidad; //asignando velocidad
    protected Transform target;
    protected Animator animZombie; //asigna movimiento de enemigo
    protected SpriteRenderer nemigoSprite;
    public float[] disFreno; 
    public string[] parametro;

    public Transform Target 
    {
        get //metodo de encapsulación 
        {
            return target; //regresa a 
        
        }

        set 
        {
            target = value; //valor asignado al target
        
        }
    
    
    }

    public float Velocidad { get; set; } //encapsulamiento de la velocidad

    public Animator AnimZombie { get; set; }

    public SpriteRenderer EnemigoSprite { get; set; } //Sprites encapsulados
  

    protected void Perseguir(Transform t)
    {

        PerseguirAtacar(t); //función para asignar 

    }

    private void PerseguirAtacar(Transform t)
    {
        Vector2 posicionTarget = new Vector2(Target.position.x, t.position.y); //detectar la posición del objetivo al perseguir
        float distanciaTarget = Vector2.Distance(posicionTarget, t.position); //mide la distancia entre el enemigo y el player 

        Debug.Log(distanciaTarget); //mensaje que se envia a la consola para la distancia asignada al target

        if (posicionTarget.x < t.position.x) //posiciones asignadas al enemigo
        {
            EnemigoSprite.flipX = true; //cuando se voltea la dirección en la que se mueve el personaje 

            if (distanciaTarget > disFreno[0]) //distancia asignada del target 
            {
                t.position = Vector2.MoveTowards(t.position, posicionTarget, Velocidad * Time.deltaTime); //movimiento hacia la posicón del target 
                AnimZombie.SetBool(parametro[0], true);  // condicionante que cambia de estado dependiendo del parametroo en que se encuentre
                AnimZombie.SetBool(parametro[1], false); //condicionante que vuelve de estado dependiendo del parametroo en que se encuentre

            }
        }

        else if (distanciaTarget <= disFreno[0])
        {

            AnimZombie.SetBool(parametro[1], true); //condicionante que cambia de estado dependiendo del parametroo en que se encuentre

        }

        else
        {
            if (distanciaTarget > disFreno[1])
            {
                EnemigoSprite.flipX = false; //movimiento hacia la posicón del target 
                t.position = Vector2.MoveTowards(t.position, posicionTarget, Velocidad * Time.deltaTime);//movimiento hacia la posicón del target 
                AnimZombie.SetBool(parametro[0], true); // condicionante que cambia de estado dependiendo del parametroo en que se encuentre
                AnimZombie.SetBool(parametro[1], false);//condicionante que vuelve de estado dependiendo del parametroo en que se encuentre
            }

            else if (distanciaTarget <= disFreno[1])
            {

                AnimZombie.SetBool(parametro[1], true); //condicionante que cambia de estado dependiendo del parametroo en que se encuentre

            }



        }


    }
}

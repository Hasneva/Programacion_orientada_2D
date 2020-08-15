using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Nombre del desarrollador: Mariana Hasneva Vazquez Rebollo
Asignatura: Programación orientada a objetos
Profesor: Josue Israel Rivas Diaz
Script: RayoRadar
Descripcion: distancia y acciones que tiene el objeto de disparo .*/
public class RayoRadar : MonoBehaviour
{

    public float distanciaRayo; //la distancia que tiene el rayo al momento de disparar
    public Transform ojos; 
    public Rigidbody2D proyectil; //cuerpo del proyectil

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot",0,3); //la acción se repite
    }

    // Update is called once per frame
    void Update()
    {
        CreadorRayo(); //decreta la función que va a hacer el objeto
    }

    void CreadorRayo() //función del objeto
    {
        var ray = new Ray2D(ojos.position, ojos.right); //variable que asigna un nuevo rayo 2D en una posición

        RaycastHit2D hitinfo = Physics2D.Raycast(ojos.position, ojos.right, distanciaRayo); //información que envia cuando el objeto golpea algo a cierta distancia

        Debug.DrawRay(ojos.position, ojos.right * distanciaRayo, Color.green); //manda mensaje a la consola del color del rayo así como la distancia

        var etiqueta = hitinfo.collider.tag; //varible que detecta la colisión a traves de un tag


        if (etiqueta=="Player") //etiqueta asignda al player
        {
            Shoot(); //decreta la función del objeto 
        }
    }

    private void Shoot() //función del objeto
    {
        Rigidbody2D proyectilPos = Instantiate(proyectil) as Rigidbody2D; //cuerpo de proyectilo instanciado
        proyectilPos.transform.position = ojos.position; //posición del objeto

                            //Vector 2 (1,0);
        proyectilPos.AddForce(ojos.right * -2000); //fuerza para el objeto

    
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Nombre de desarrollador: Mariana Hasneva Vazquez Rebollo
Asignatura:Programacion Orientada a Objetos
Profesor:Josue Israel Rivas Diaz
Nombre de código:Player1
Descripción: Aqui se establecen los datos base del personaje ademas de sus comandos de movimiento y condicionantes para su animacion y fisicas2D.*/
public class Player1 : MonoBehaviour
{
    #region Variables
    // 1.- Se llama al plano o blueprint ConstructorPersonaje
    // 2.- Se le da un ID Bob
    // 3.- Se inicializa el dato como un objeto "new" ConstructorPersonaje

    public Transform Starpoint;

    public ConstructorPersonaje Bob = new ConstructorPersonaje();
    //Interfaz para controlar el sistema de animación.
    public static Animator animarRiley;

    

    //Representa un Sprite para gráficos 2D.
    SpriteRenderer spriteFairy;
    //Agrega un control de fisica (funciona de manera similar al rigidbody3d)
    Rigidbody2D fisicasRB2D;
    //SerializeField =  campo privado



    public static int vidaPlayer = 40;//Vida del personaje

    [SerializeField]//Hace visible las variables privadas en la jerarquia
    // componente suela zapatos
    Transform suelaZapatos;
    [SerializeField]
    //Indica la "medida" de la base del personaje llamada "zapatos"
    float numeroZapato;
    [SerializeField]
    LayerMask terreno;
    [SerializeField]
    //Indica la cantidad de fuerza para que el personaje salte 
    float fuerzasaltopersonaje;
    float Velocidad = 5f;


    public bool piso;
    public bool jump;
    public bool jugar = true;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        #region Datos
        //++++++++++++++++Datos de Personaje++++++++++++++++++

        //Asignacion del nombre del persoanje
        Bob.nombre = "Fairy";
        //Da el nombre de Bob.nombre al objeto llamado en Unity
        gameObject.name = Bob.nombre;
        //Valor de vida
        Bob.vida = vidaPlayer;
        //Cuanto daño provo1ca el player
        Bob.daño = 10;
        //++++++++++++++++++++++++++++++++++

        //+++++++++++Inicializacion de componentes+++++++++

        animarRiley = GetComponent<Animator>();
        spriteRiley = GetComponent<SpriteRenderer>();
        fisicasRB2D = GetComponent<Rigidbody2D>();
        //++++++++++++++++++++++++++++++++++
        #endregion
    }

    // Update is called once per frame
    void Update()
    {

        if (jugar == true)
        {
            Bob.vida = vidaPlayer;

            #region control izq. y der.
            //Invocar variable
            //Llamas a lo que quieres utilizar de Bob(constructor del personaje)
            //estableces los controles de movimiento gracias al "Input.GetKey", estos funcionan cada que el jugador prrsione la flecha establecida
            //Playanimation reproduce una animacion si mezclarla con otra (pasar de la respiracion al movimiento)
            //flip.X gira el sprite en el eje de X para voltear a la izquierda y a la derecha

            //Si presionas flecha derecha, el personaje caminara a la derecha
            if (Input.GetKey(KeyCode.RightArrow))
            {
                Bob.Movimiento(fisicasRB2D, Velocidad);
                Bob.PlayAnimation(animarFairy, "Velocidad", true);
                spriteRiley.flipX = false;
            }
            //Si presionas flecha flecha izquierda, el personaje caminara a la izquierda
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                Bob.Movimiento(fisicasRB2D, -Velocidad);
                Bob.PlayAnimation(animarFairy, "Velocidad", true);
                spriteRiley.flipX = true;
            }
            else
            {
                Bob.PlayAnimation(animarFairy, "Velocidad", false);
                Bob.Movimiento(fisicasRB2D, 0.0f);
            }
            


        }

        if (Bob.vida <= 0)
        {
            jugar = false;
            animarRiley.Play("dead_cat");
             #endregion
        }
        #region control de movimiento 2
        Bob.vida = vidaPlayer;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Bob.Movimiento(fisicasRB2D, Velocidad);
            Bob.PlayAnimation(animarFairy, "Velocidad", true);
            spriteRiley.flipX = false;
        }
        //Si presionas flecha flecha izquierda, el personaje caminara a la izquierda
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Bob.Movimiento(fisicasRB2D, -Velocidad);
            Bob.PlayAnimation(animarFairy, "Velocidad", true);
            spriteRiley.flipX = true;
        }
        else
        {
            Bob.PlayAnimation(animarFairy, "Velocidad", false);
            Bob.Movimiento(fisicasRB2D, 0.0f);
        }

        if (Bob.vida<=0)
        {
            jugar = false;
            StartCoroutine("Muerte");

        }
        // Clamp: Sujeta el valor dado entre los valores flolat mínimos y float maximos dados. Devuelve el valor dado si está dentro del rango mínimo y máximo.
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, - 19.5f, 19.5f), transform.position.y, transform.position.z);
        #endregion
    }


    private void FixedUpdate()
    
    #region Salto
    {
    //Es llamado cada cuadro y mantiene la lectura de cuadros en 50
    //FixedUpdate: Es ideal para registrar fuerzas que imitan la fisica
    //Mide la velocidad de fotogramas comparando FixedUpdate con Update
        //Si presionas tecla space y bob esta en piso...
        if (Input.GetKeyDown(KeyCode.Space) && Bob.estoyEnPiso(suelaZapatos,numeroZapato,terreno))
        {
            fisicasRB2D.AddForce(Vector2.up*fuerzasaltopersonaje,ForceMode2D.Impulse);

        }
    }
    #endregion
    IEnumerator Muerte()
    {

        //Yield return: regreso
        jugar = false;
        animarRiley.Play("dead_cat");
        yield return new WaitForSeconds(1);
        spriteRiley.enabled = false;
        transform.position = Starpoint.position;
        yield return new WaitForSeconds(1);
        spriteRiley.enabled = true;
        jugar = true;
        vidaPlayer = 3;
        yield return null;
        

    }
}

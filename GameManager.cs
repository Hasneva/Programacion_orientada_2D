using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;
/*Nombre del desarrollador: Mariana Hasneva Vazquez Rebollo
Asignatura: Programación orientada a objetos
Profesor: Josue Israel Rivas Diaz
Script: GameManger
Descripcion: Administrador general del juego.*/

public class GameManager : MonoBehaviour
{
    //Sets:Guardar el dato en registro
    //Gets: recuperan el dato desde el registro
    //Este GameManager se estara cargando en tosas las escenas
    //Por medio de este puedo llegar a los datos que contiene GameManager
    private static GameManager instance;

    public string nombrejugador;
    public int vidajugador;
    public int poderjugador;

    public int nivelDeJuego;

    public float[] puntosposicion;


    //Posicion en la que se encuentra el punto de guardado
    public Vector3 checkpointPosition = Vector3.zero;


    //Proteger la base del proyecto
    public static GameManager Instance
    {

        get
        {
            //
            return instance;
        }

        set
        {

        }
    }


    private void Awake()
    {
        if (instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);//Este objeto es indestructible 
        }
        else
        {
            DestroyImmediate(this);
        }
    }

    void Start()
    {
        //Puntos X, Y y Z almacenados en arreglos
        puntosposicion = new float[3];
        vidajugador = 3;
        poderjugador = 10;
        nivelDeJuego = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IniciarJuego()
    {
        GuardarJuego();
        //carga la escena del nievel
        SceneManager.LoadScene(nivelDeJuego);
    }
    //Guardar los datos originales y sus modificaciones
    public void GuardarJuego()
    {
        //Guarda el dato del Player pref
        PlayerPrefs.SetString("nombreJ", nombrejugador);

        //guardan los valores recuperados de nivel de juego, vidajuador, poderjugador y puntosposicion

        PlayerPrefs.SetInt("Vida", vidajugador);

        PlayerPrefs.SetInt("poder", poderjugador);

        PlayerPrefs.SetInt("nivel", nivelDeJuego);

        PlayerPrefs.SetFloat("x", puntosposicion[0]);

        PlayerPrefs.SetFloat("y", puntosposicion[1]);

        PlayerPrefs.SetFloat("z", puntosposicion[2]);


    }

    //Cargar los datos una ves modificados en una partida
    public void CargarJuego()
    {
        nombrejugador = PlayerPrefs.GetString("nombreJ");
        vidajugador = PlayerPrefs.GetInt("vida");
        poderjugador = PlayerPrefs.GetInt("poder");
        nivelDeJuego = PlayerPrefs.GetInt("nivel");
        checkpointPosition = new Vector3(PlayerPrefs.GetFloat("x"), PlayerPrefs.GetFloat("y"), PlayerPrefs.GetFloat("z"));
        


        //Regresa el dato del nombre Jugador
        Debug.Log(nombrejugador);
    }
}

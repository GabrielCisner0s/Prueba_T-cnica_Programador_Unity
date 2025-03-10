using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class Player_Controller : MonoBehaviour
{
    public Vector3 Movimiento;//vector de movimiento
    public float Velocidad;//var velocidad
    public GameObject bala;//objeto bala
    public float Timer, TiempoDeEspera;
    public int Puntos;//variable donde se guardara la puntuacion
    public TextMeshProUGUI Puntuacion;//variable donde se mostrara la puntuacion
    public int vida_jugador;//vida de jugador


    // Se ejecutara antes del primer frame del juego(una sola vez)
    void Start()
    {
        
    }

    // Se ejecutara en cada frame del Juego
    void Update()
    {
        //movimiento
        Movimiento = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
        Movimiento = Movimiento.normalized;
        transform.position += Movimiento * Velocidad* Time.deltaTime;

        // Detecta el clic del ratón  
        if (Input.GetMouseButtonDown(0) && Timer <=0) // 0 es el botón izquierdo del ratón  
        {
            Instantiate(bala, transform.position, Quaternion.Euler(0, 0, 90));//instancia un proyectil en el escenario
            Timer = TiempoDeEspera;//tiempo de espera pa
        }

        Timer -= Time.deltaTime;

        Puntuacion.text = "Score: "+Puntos.ToString("");//pasa el entero a string y lo muestra en pantalla

    }




    /*
    //detecta coliciones con el enemigo
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //si el objeto con el que coliciona tiene de nombre...
        if (collision.gameObject.name == "Enemigo1")
        {
          
            
            Destroy(gameObject);//el objeto se destruye
            SceneManager.LoadScene("MainMenu");//cambia de escena
            
            
        }

    }*/





}

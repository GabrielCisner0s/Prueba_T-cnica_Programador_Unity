using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
   
    public float VelocidadBajada;
    
    public int Vida;//vida enemigo

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, VelocidadBajada * Time.deltaTime, 0);
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("choco");
            // Aquí puedes añadir lógica para dañar al enemigo  
            Destroy(collision.gameObject); // Destruir al enemigo al impactar 
            Destroy(gameObject); // Destruir la bala
            SceneManager.LoadScene("MainMenu");//regresa al menu de inicio                 
        }
    }

    /*
    //detecta las coliciones de la bala y player
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //si el objeto con el que coliciona tiene de nombre...
        if (collision.gameObject.name == "Player")
        {
            
            Destroy(gameObject);//se destruye el enemigo
        }
        if (collision.gameObject.name == "Plasma")
        {
            //encuentra el objeto Player, busca su componente Player_Controller y le suma 1 a su variable puntos
            GameObject.Find("Player").GetComponent<Player_Controller>().Puntos += 1;
            Destroy(gameObject);
        }

    }*/
}

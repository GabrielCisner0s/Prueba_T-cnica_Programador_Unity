using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//libreria para cambio de escenas



public class main_menu : MonoBehaviour
{
   
    //metodo para cambiar de escena
    public void CambioEscenaJuego()
    {
        
        SceneManager.LoadScene("Game");//escena del juego    
    }


    //carga datos guardados en Json
    public void cargarGuardado()
    { 
    
    }


    //boton salir
    public void Salir()
    {
        Application.Quit();
    }

}

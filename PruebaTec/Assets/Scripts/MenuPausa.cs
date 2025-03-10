using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject menuPausa;
    public bool juegoPausado = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
   

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (juegoPausado)
            {
                Reanudar();
            }
            else
            {
                Pausar();
            }

        }
    }


    //metodo que reanuda el juego
    public void Reanudar()
    {
        menuPausa.SetActive(false);
        Time.timeScale = 1;//tiempo de juego 
        juegoPausado = false;
    }

    public void Pausar()
    {
        menuPausa.SetActive(true);
        Time.timeScale = 0;//tiempo de juego 
        juegoPausado = false;

    }

    //boton salir
    public void Salir()
    {
        Application.Quit();
    }
}

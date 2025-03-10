using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class ControladorDatos : MonoBehaviour
{

    public GameObject jugador;//objeto jugador
    public string archivoDeGuardado;
    public DatosJuego datosJuego = new DatosJuego();

    private void Awake()
    {
        archivoDeGuardado = Application.dataPath + "/datosJuego.json";
        jugador = GameObject.FindGameObjectWithTag("Player");
    }


    public void CargarDatos()
    {
        if (File.Exists(archivoDeGuardado))
        {
            string contendio = File.ReadAllText(archivoDeGuardado);
            datosJuego = JsonUtility.FromJson<DatosJuego>(contendio);

            Debug.Log("Posicion jugador: " + datosJuego.posicion);

            jugador.transform.position = datosJuego.posicion;
            jugador.GetComponent<Player_Controller>().Puntos = datosJuego.score;
        }
        else {

            Debug.Log("El archivo no se cargo");
        }
    }

    public void GuardarDatos()
    {
        DatosJuego nuevosDatos = new DatosJuego()
        {
            posicion = jugador.transform.position,
            score = jugador.GetComponent<Player_Controller>().Puntos
        };

        string cadenaJSON = JsonUtility.ToJson(nuevosDatos);
        File.WriteAllText(archivoDeGuardado, cadenaJSON);

        Debug.Log("ARCHIVO GUARDADO");
    
    }

}

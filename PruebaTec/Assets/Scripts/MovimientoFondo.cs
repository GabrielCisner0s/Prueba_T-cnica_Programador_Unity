using UnityEngine;

public class MovimientoFondo : MonoBehaviour
{
    public float Velocidad;//velocidad a la que se movera el fondo espacial
    public GameObject ObjDebajo;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y <= -13.5f)//cuando la posicion del fondo este por debajo de -13.5f
        {
            transform.position = ObjDebajo.transform.position +new Vector3(0, 13.5f, 0);//cambiara su posicion
        }

        transform.position += new Vector3(0, Velocidad * Time.deltaTime, 0);//movimiento del fondo por segundo

      

    }
}

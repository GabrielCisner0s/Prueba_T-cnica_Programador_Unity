using UnityEngine;

public class bala : MonoBehaviour
{
    public float Velocidad;//velocidad de proyectil
    private Renderer rend;//El Renderer es lo que dibuja el objeto en la pantalla.
    

    void Start()
    {
        //Obtiene el componente Renderer del GameObject al que está adjunto este script y lo asigna a la variable rend.
        rend = GetComponent<Renderer>();
        
        //El proyectil aparece en pantalla girado -90 grados
        transform.Rotate(0f,0f, -90f);
    }

   
    void Update()
    {
        transform.position += new Vector3(0, Velocidad * Time.deltaTime, 0);

        
        //si la bala esta fuera de la vista de la camara
        if (!rend.isVisible)
        {
            //entonces se destruye
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("enemy"))
        {
            Debug.Log("choco");
            //suma un punto al matar al enemigo 
            GameObject.Find("Player").GetComponent<Player_Controller>().Puntos += 1;
            Destroy(collision.gameObject); // Destruir al enemigo al impactar 
            Destroy(gameObject); // Destruir la bala  
        }
    }











    /*
    //detecta las coliciones de la bala
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //si el objeto con el que coliciona tiene de nombre...
        if (collision.gameObject.name == "Enemigo1")
        {
            //recorrera el objeto para tener el componente Vida y le restarà -1
            // collision.gameObject.GetComponent<Enemy>().Vida -=1;
            Destroy(gameObject);//seguido de eso se destruira la bala
        }
        
    }*/
}

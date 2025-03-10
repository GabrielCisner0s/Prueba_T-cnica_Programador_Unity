using UnityEngine;

public class Spawner_enemy : MonoBehaviour
{

    public GameObject Enemigo;
    public float Timer, TiempoEspera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer <= 0)
        {
            Instantiate(Enemigo, new Vector3(0,10,0), Quaternion.Euler(0,0,0));
            Timer = TiempoEspera;
        }
        Timer -= Time.deltaTime;
    }
}

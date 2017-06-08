using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generarObstaculo : MonoBehaviour {

    public GameObject[] obs;
    public string partitura;
    public float tiempoMin = 1f;
    public float tiempoMax = 1f;
    
    // Use this for initialization
    void Start()
    {
       // int size = partitura.Split(',').Length;
        generar();
        
    }

    

    // Update is called once per frame
    void Update()
    {
       // Invoke("generar", Random.Range(tiempoMin, tiempoMax));
    }

    void generar()
    {

        Instantiate(obs[Random.Range(0, obs.Length)], transform.position, Quaternion.identity);
        Invoke("generar", Random.Range(tiempoMin, tiempoMax));
    }
}

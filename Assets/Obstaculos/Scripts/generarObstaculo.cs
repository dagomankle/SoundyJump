using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generarObstaculo : MonoBehaviour {

    public GameObject[] obs;
    public string partitura;
    public float tiempoMin = 1f;
    public float tiempoMax = 1f;
    private int contador = 0;
    private string[] notas;
    // Use this for initialization
    void Start()
    {
       notas = partitura.Split(',');
        generar();
        
    }

    void Update()
    {
      
    }

    void generar()
    {

        if (contador < notas.Length)
        {
            int index = 0;

            if (notas[contador].Equals("N"))
                index = 0;
            if (notas[contador].Equals("R"))
                index = 1;
            if(notas[contador].Equals("B"))
                index = 2;

            Instantiate(obs[index], transform.position, Quaternion.identity);
            contador++;
            Invoke("generar", Random.Range(tiempoMin, tiempoMax));
        }
    }
}

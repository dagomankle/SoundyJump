using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desplazamiento : MonoBehaviour {


    // Use this for initialization
    public float velocidad = 0.5f;
    public bool pausa = false;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("escape"))
        {
            PausaChange();
        }

        if(pausa == false)
            transform.position = new Vector3(transform.position.x - velocidad, transform.position.y, transform.position.z);
    }


    void PausaChange()
    {
        if (pausa == false)
            pausa = true;
        else
            pausa = false;
    }
}
